using HastaOtomasyonLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class HastaGüncellemeForm : BaseForm
    {
        public HastaGüncellemeForm()
        {
            InitializeComponent();
        }
        public List<Hasta> Hastalar { get; set; }
        Hasta seciliHasta = new Hasta();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Hasta yeniHasta = new Hasta()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Cinsiyet = (Cinsiyetler)(Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString())),
                    Telefon = txtTelefon.Text
                };
                Hastalar.Add(yeniHasta);
                FormuTemizle();
                ListeyiDoldur();
                MessageBox.Show("Hasta Kaydı başarıyla eklendi.","Hasta Kaydetme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ListeyiDoldur()
        {
            lstListe.Items.Clear();
            foreach (Hasta item in Hastalar)
            {
                lstListe.Items.Add(item);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliHasta == null)
            {
                MessageBox.Show("Güncellemek için hasta seçmelisiniz!");
                return;
            }
            DialogResult cevap = MessageBox.Show($"{seciliHasta.Ad} adlı hastayı güncellemek üzeresiniz! Devam etmek istiyor musunuz?", "Kişi Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    seciliHasta = Hastalar.Where(item => item.TCKN == seciliHasta.TCKN).FirstOrDefault();
                    seciliHasta.Ad = txtAd.Text;
                    seciliHasta.Soyad = txtSoyad.Text;
                    seciliHasta.DogumTarihi = dtpDogumTarihi.Value;
                    seciliHasta.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler),
                    cmbCinsiyet.SelectedItem.ToString());
                    seciliHasta.Telefon = txtTelefon.Text;
                    FormuTemizle();
                    ListeyiDoldur();
                    seciliHasta = null;
                    MessageBox.Show("Güncelleme başarıyla gerçekleşti","Güncelleme başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            seciliHasta = lstListe.SelectedItem as Hasta;
            txtAd.Text = seciliHasta.Ad;
            dtpDogumTarihi.Value = seciliHasta.DogumTarihi;
            txtSoyad.Text = seciliHasta.Soyad;
            cmbCinsiyet.SelectedIndex = (int)seciliHasta.Cinsiyet;
            txtTelefon.Text = seciliHasta.Telefon;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliHasta == null)
            {
                MessageBox.Show("Silmek için hasta seçmediniz!");
                return;
            }
            seciliHasta = (Hasta)lstListe.SelectedItem;
            DialogResult cevap = MessageBox.Show($"{ seciliHasta.Ad} adlı hastayı silmek istiyor musunuz?", "Öğrenci Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Hastalar.Remove(seciliHasta);
                ListeyiDoldur();
                seciliHasta = null;
                MessageBox.Show("Öğrenci başarıyla silindi");
            }
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Hasta> aramaSonucu = Methods.Ara(Hastalar, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }
        private void ListeyiDoldur(List<Hasta> aramaSonucu)
        {
            lstListe.Items.Clear();
            foreach (Hasta item in aramaSonucu)
            {
                lstListe.Items.Add(item);
            }
        }
        private void HastaKayıtForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            ListeyiDoldur();
        }
    }
}
