using HastaOtomasyonLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class DoktorGüncelleForm :CalisanBaseForm
    {
        public DoktorGüncelleForm()
        {
            InitializeComponent();
        }
        private void DoktorForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(SaglıkBranslar)));
            ListeyiDoldurDoktor();
        }
        public List<Doktor> Doktorlar { get; set; }
        Doktor seciliDoktor = new Doktor();
        public List<Hemsire> Hemsireler { get; set; }
        public List<Hemsire> BostakiHemsireler { get; set; }
        private Hemsire seciliBostakiHemsire, seciliBagliHemsire;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Doktor seciliDoktor = new Doktor()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Maas = nMaas.Value,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Telefon = txtTelefon.Text,
                    Brans = (SaglıkBranslar)Enum.Parse(typeof(SaglıkBranslar), cmbBrans.SelectedItem.ToString()),
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString())
                };
                this.Doktorlar.Add(seciliDoktor);
                ListeyiDoldurDoktor();
                FormuTemizle();
                MessageBox.Show("Doktor ekleme işlemi başarılı","Doktor Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliDoktor == null)
            {
                MessageBox.Show("Güncelemek için Doktor seçmelisiniz?");
                return;
            }
            DialogResult cevap = MessageBox.Show($"{seciliDoktor.Ad} adlı kişiyi güncellemek üzeresiniz! Devam etmek istiyor musunuz?", "Kişi Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    seciliDoktor = Doktorlar.Where(item => item.TCKN == seciliDoktor.TCKN).FirstOrDefault();
                    seciliDoktor.Ad = txtAd.Text;
                    seciliDoktor.Soyad = txtSoyad.Text;
                    seciliDoktor.DogumTarihi = dtpDogumTarihi.Value;
                    seciliDoktor.Maas = nMaas.Value;
                    seciliDoktor.Telefon = txtTelefon.Text;
                    seciliDoktor.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler),
                    cmbCinsiyet.SelectedItem.ToString());
                    seciliDoktor.Brans = (SaglıkBranslar)Enum.Parse(typeof(SaglıkBranslar),
cmbBrans.SelectedItem.ToString());
                    ListeyiDoldurDoktor();
                    seciliDoktor = null;
                    MessageBox.Show("Güncelleme başarılı", "Güncelleme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliDoktor == null)
            {
                MessageBox.Show("Silemk için öğrenci seçmediniz!");
                return;
            }
            seciliDoktor = (Doktor)lstListe.SelectedItem;
            DialogResult cevap = MessageBox.Show($"{ seciliDoktor.Ad} adlı öğrenciyi silmek istiyor musunuz?", "Öğrenci Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Doktorlar.Remove(seciliDoktor);
                foreach (Hemsire item in seciliDoktor.BagliHemsireler)
                {
                    item.DoktorId = null;
                }

                ListeyiDoldurDoktor();
                seciliDoktor = null;
                MessageBox.Show("Doktor başarıyla silindi");
            }
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Doktor> aramaSonucu = Methods.Ara(Doktorlar, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex == -1) return;
            seciliDoktor = lstListe.SelectedItem as Doktor;
            txtAd.Text = seciliDoktor.Ad;
            dtpDogumTarihi.Value = seciliDoktor.DogumTarihi;
            txtSoyad.Text = seciliDoktor.Soyad;
            nMaas.Value = seciliDoktor.Maas;
            txtTelefon.Text = seciliDoktor.Telefon;
            cmbBrans.SelectedIndex = (int)seciliDoktor.Brans;
            cmbCinsiyet.SelectedIndex = (int)seciliDoktor.Cinsiyet;
            cmbBrans.Enabled = false;
            BostakiHemsireler = Hemsireler.Where(hemsire => seciliDoktor.Brans == hemsire.Brans).ToList();
            seciliDoktor.BagliHemsireler = Hemsireler.Where(hemsire => seciliDoktor.TCKN == hemsire.DoktorId).ToList();
            ListeyiDoldurBostakiHemsire();
            ListeyiDoldurBagliHemsireler();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex == -1)
            {
                MessageBox.Show("Önce doktor seçimi yapmalısınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lstBostakiHemsireler.SelectedIndex == -1)
            {
                MessageBox.Show("Boşta olan hemşirelerden bir seçim yapılmadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            seciliDoktor = lstListe.SelectedItem as Doktor;
            seciliBostakiHemsire = lstBostakiHemsireler.SelectedItem as Hemsire;
            seciliDoktor.BagliHemsireler.Add(seciliBostakiHemsire);
            BostakiHemsireler.Remove(seciliBostakiHemsire);
            seciliBostakiHemsire.DoktorId = seciliDoktor.TCKN;
            ListeyiDoldurBostakiHemsire();
            ListeyiDoldurBagliHemsireler();
        }
        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex == -1)
            {
                MessageBox.Show("Önce doktor seçimi yapmalısınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lstBagliHemsireler.SelectedIndex == -1)
            {
                MessageBox.Show("Bağlı olan hemşirelerden bir seçim yapılmadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            seciliDoktor = lstListe.SelectedItem as Doktor;
            seciliBagliHemsire = lstBagliHemsireler.SelectedItem as Hemsire;
            seciliBagliHemsire.DoktorId = null;
            BostakiHemsireler = Hemsireler.Where(hemsire => seciliDoktor.Brans == hemsire.Brans).ToList();
            seciliDoktor.BagliHemsireler = Hemsireler.Where(hemsire => seciliDoktor.TCKN == hemsire.DoktorId).ToList();
            seciliDoktor.BagliHemsireler.Remove(seciliBagliHemsire);
            if (BostakiHemsireler.Count == 0)
                BostakiHemsireler.Add(seciliBagliHemsire);
            ListeyiDoldurBostakiHemsire();
            ListeyiDoldurBagliHemsireler();
        }
        private void ListeyiDoldurBostakiHemsire()
        {
            lstBostakiHemsireler.Items.Clear();
            foreach (Hemsire item in BostakiHemsireler)
            {
                if (item.DoktorId == null)
                    lstBostakiHemsireler.Items.Add(item);
            }
        }
        private void ListeyiDoldurBagliHemsireler()
        {
            lstBagliHemsireler.Items.Clear();
            foreach (Hemsire item in seciliDoktor.BagliHemsireler)
            {
                if (item.DoktorId != null)
                    lstBagliHemsireler.Items.Add(item);
            }
        }
        private void ListeyiDoldurDoktor()
        {
            lstListe.Items.Clear();
            foreach (Doktor item in Doktorlar)
            {
                lstListe.Items.Add(item);
            }
        }

        private void ListeyiDoldur(List<Doktor> aramaSonucu)
        {
            lstListe.Items.Clear();
            foreach (Doktor item in aramaSonucu)
            {
                lstListe.Items.Add(item);
            }
        }
    }
}
