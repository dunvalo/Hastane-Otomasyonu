using HastaOtomasyonLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class PersonelGüncelleForm : CalisanBaseForm
    {
        public PersonelGüncelleForm()
        {
            InitializeComponent();
        }
        Personel seciliPersonel = new Personel();
        public List<Personel> Personeller { get; set; }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(PersonelBranslar)));
            ListeyiDoldur();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Personel seciliPersonel = new Personel()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Maas = nMaas.Value,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Telefon = txtTelefon.Text,
                    PersonelBrans = (PersonelBranslar)Enum.Parse(typeof(PersonelBranslar), cmbBrans.SelectedItem.ToString()),
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString())
                };
                this.Personeller.Add(seciliPersonel);
                ListeyiDoldur();
                //FormuTemizle();
                MessageBox.Show("Personel ekleme işlemi başarılı", "Personel Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliPersonel == null)
            {
                MessageBox.Show("Güncelemek için Personel seçmelisiniz?");
                return;
            }
            DialogResult cevap = MessageBox.Show($"{seciliPersonel.Ad} adlı kişiyi güncellemek üzeresiniz! Devam etmek istiyor musunuz?", "Kişi Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    seciliPersonel = Personeller.Where(item => item.TCKN == seciliPersonel.TCKN).FirstOrDefault();
                    seciliPersonel.Ad = txtAd.Text;
                    seciliPersonel.Soyad = txtSoyad.Text;
                    seciliPersonel.DogumTarihi = dtpDogumTarihi.Value;
                    seciliPersonel.Maas = nMaas.Value;
                    seciliPersonel.Telefon = txtTelefon.Text;
                    seciliPersonel.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler),
                    cmbCinsiyet.SelectedItem.ToString());
                    seciliPersonel.PersonelBrans = (PersonelBranslar)Enum.Parse(typeof(PersonelBranslar),
cmbBrans.SelectedItem.ToString());
                    ListeyiDoldur();
                    seciliPersonel = null;
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
            if (seciliPersonel == null)
            {
                MessageBox.Show("Silmek için öğrenci seçmediniz!");
                return;
            }
            seciliPersonel = (Personel)lstListe.SelectedItem;
            DialogResult cevap = MessageBox.Show($"{ seciliPersonel.Ad} adlı personeli silmek istiyor musunuz?", "Öğrenci Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Personeller.Remove(seciliPersonel);
                ListeyiDoldur();
                seciliPersonel = null;
                MessageBox.Show("Personel başarıyla silindi");
            }
        }
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex == -1) return;
            seciliPersonel = lstListe.SelectedItem as Personel;
            txtAd.Text = seciliPersonel.Ad;
            dtpDogumTarihi.Value = seciliPersonel.DogumTarihi;
            txtSoyad.Text = seciliPersonel.Soyad;
            nMaas.Value = seciliPersonel.Maas;
            txtTelefon.Text = seciliPersonel.Telefon;
            cmbBrans.SelectedIndex = (int)seciliPersonel.PersonelBrans;
            cmbCinsiyet.SelectedIndex = (int)seciliPersonel.Cinsiyet;
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Personel> aramaSonucu = Methods.Ara(Personeller, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }
        private void ListeyiDoldur()
        {
            lstListe.Items.Clear();
            foreach (Personel item in Personeller)
            {
                lstListe.Items.Add(item);
            }
        }
        private void ListeyiDoldur(List<Personel> aramaSonucu)
        {
            lstListe.Items.Clear();
            foreach (Personel item in aramaSonucu)
            {
                lstListe.Items.Add(item);
            }
        }
    }
}
