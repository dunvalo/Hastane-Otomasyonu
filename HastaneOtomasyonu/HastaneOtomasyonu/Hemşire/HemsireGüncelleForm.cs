using HastaOtomasyonLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class HemsireGüncelleForm : CalisanBaseForm
    {
        public HemsireGüncelleForm()
        {
            InitializeComponent();
        }
        public List<Hemsire> Hemsireler { get; set; }
        Hemsire seciliHemsire = new Hemsire();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Hemsire yeniHemsire = new Hemsire()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Cinsiyet = (Cinsiyetler)(Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString())),
                    Maas = nMaas.Value,
                    Brans = (SaglıkBranslar)(Enum.Parse(typeof(SaglıkBranslar), cmbBrans.SelectedItem.ToString())),
                    Telefon = txtTelefon.Text 
                };
                Hemsireler.Add(yeniHemsire);
                FormuTemizle();
                ListeyiDoldur();
                MessageBox.Show($"Hemşire başarıyla eklendi.","Hemşire Kaydetme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliHemsire == null)
            {
                MessageBox.Show("Güncellemek için hemşire seçmelisiniz!");
                return;
            }
            DialogResult cevap = MessageBox.Show($"{seciliHemsire.Ad} adlı hemşireyi güncellemek üzeresiniz! Devam etmek istiyor musunuz?", "Kişi Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    seciliHemsire = Hemsireler.Where(item => item.TCKN == seciliHemsire.TCKN).FirstOrDefault();
                    seciliHemsire.Ad = txtAd.Text;
                    seciliHemsire.Soyad = txtSoyad.Text;
                    seciliHemsire.DogumTarihi = dtpDogumTarihi.Value;
                    seciliHemsire.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler),
                    cmbCinsiyet.SelectedItem.ToString());
                    seciliHemsire.Brans = (SaglıkBranslar)Enum.Parse(typeof(SaglıkBranslar), cmbBrans.SelectedItem.ToString());
                    seciliHemsire.Telefon = txtTelefon.Text;
                    seciliHemsire.Maas = nMaas.Value;
                    FormuTemizle();
                    ListeyiDoldur();
                    seciliHemsire = null;
                    MessageBox.Show("Güncelleme başarıyla gerçekleşti","Güncelleme Ekranı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex == -1) return;
            seciliHemsire = lstListe.SelectedItem as Hemsire;
            txtAd.Text = seciliHemsire.Ad;
            dtpDogumTarihi.Value = seciliHemsire.DogumTarihi;
            txtSoyad.Text = seciliHemsire.Soyad;
            cmbCinsiyet.SelectedIndex = (int)seciliHemsire.Cinsiyet;
            nMaas.Value = seciliHemsire.Maas;
            cmbBrans.SelectedIndex = (int)seciliHemsire.Brans;
            txtTelefon.Text = seciliHemsire.Telefon;
        }
        private void HemsireForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(SaglıkBranslar)));
            ListeyiDoldur();
        }
        private void ListeyiDoldur()
        {
            lstListe.Items.Clear();
            foreach (Hemsire item in Hemsireler)
            {
                lstListe.Items.Add(item);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliHemsire == null)
            {
                MessageBox.Show("Silmek için hemşire seçmediniz!");
                return;
            }
            seciliHemsire = (Hemsire)lstListe.SelectedItem;
            DialogResult cevap = MessageBox.Show($"{ seciliHemsire.Ad} adlı hemşireyi silmek istiyor musunuz?", "Öğrenci Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Hemsireler.Remove(seciliHemsire);
                ListeyiDoldur();
                seciliHemsire = null;
                MessageBox.Show("Öğrenci başarıyla silindi");
            }
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Hemsire> aramaSonucu = Methods.Ara(Hemsireler, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }
        private void ListeyiDoldur(List<Hemsire> aramaSonucu)
        {
            lstListe.Items.Clear();
            foreach (Hemsire item in aramaSonucu)
            {
                lstListe.Items.Add(item);
            }
        }
    }
}
