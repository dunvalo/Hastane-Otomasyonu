using HastaOtomasyonLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class RandevuIslemleri : Form
    {
        public RandevuIslemleri()
        {
            InitializeComponent();
            btn9.Click += btnRandevuSaati_Click;
            btn915.Click += btnRandevuSaati_Click;
            btn930.Click += btnRandevuSaati_Click;
            btn945.Click += btnRandevuSaati_Click;
            btn10.Click += btnRandevuSaati_Click;
            btn1015.Click += btnRandevuSaati_Click;
            btn1030.Click += btnRandevuSaati_Click;
            btn1045.Click += btnRandevuSaati_Click;
            btn11.Click += btnRandevuSaati_Click;
            btn1115.Click += btnRandevuSaati_Click;
            btn1130.Click += btnRandevuSaati_Click;
            btn1145.Click += btnRandevuSaati_Click;
            btn13.Click += btnRandevuSaati_Click;
            btn1315.Click += btnRandevuSaati_Click;
            btn1330.Click += btnRandevuSaati_Click;
            btn1345.Click += btnRandevuSaati_Click;
            btn14.Click += btnRandevuSaati_Click;
            btn1415.Click += btnRandevuSaati_Click;
            btn1430.Click += btnRandevuSaati_Click;
            btn1445.Click += btnRandevuSaati_Click;
        }
        Color seciliRenk = Color.DarkSalmon;
        Color secilmemisRenk = Color.LightGreen;
        Color doluRenk = Color.LightGray;
        public List<Hasta> Hastalar { get; set; }
        public List<Doktor> Doktorlar { get; set; }
        public List<Doktor> BransDoktorlari { get; set; }
        public List<Randevu> Randevular { get; set; }
        public Button seciliButon = null;
        private Hasta seciliHasta;
        private Doktor seciliDoktor;

        private void btnRandevuSaati_Click(object sender, EventArgs e)
        {
            string saat = (sender as Button).Text;
            seciliButon = sender as Button;
            foreach (Button item in gbRandevuSaati.Controls)
            {
                if (seciliDoktor.DoktorunRandevuSaatleri.ToString() == item.Text)
                    item.Enabled = false;
                if (item.Enabled == true)
                    item.BackColor = secilmemisRenk;
                seciliButon.BackColor = seciliRenk;
            }
        }
        private void lstHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHasta.SelectedIndex == -1)
            {
                seciliHasta = null;
                gbRandevu.Visible = false;
                return;
            }
            seciliHasta = lstHasta.SelectedItem as Hasta;
            txtAd.Text = seciliHasta.Ad;
            txtSoyad.Text = seciliHasta.Soyad;
            dtpDogumTarihi.Value = seciliHasta.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)seciliHasta.Cinsiyet;
            gbRandevu.Visible = true;
        }
        private void ListeyiDoldur()
        {
            lstHasta.Items.Clear();
            foreach (Hasta item in Hastalar)
            {
                lstHasta.Items.Add(item);
            }
        }
        private void RandevuIslemleri_Load(object sender, EventArgs e)
        {
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(SaglıkBranslar)));
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            ListeyiDoldur();
        }
        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BransDoktorlari != null)
                BransDoktorlari.Clear();
            BransDoktorlari = Doktorlar.Where(item => cmbBrans.SelectedIndex == (int)item.Brans).ToList();
            cmbDoktorlar.Items.Clear();
            cmbDoktorlar.Items.AddRange(BransDoktorlari.ToArray());
        }
        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliDoktor = cmbDoktorlar.SelectedItem as Doktor;
            seciliDoktor.DoktorunRandevulari = Randevular.Where(item => seciliDoktor.TCKN == item.DoktorID).ToList();
            foreach (Button item in gbRandevuSaati.Controls)
            {
                item.BackColor = secilmemisRenk;
                item.Enabled = true;
                foreach (Randevu saat in seciliDoktor.DoktorunRandevulari)
                {
                    if (item.Text == saat.Saat)
                    {
                        item.Enabled = false;
                        item.BackColor = doluRenk;
                    }
                }
            }
            gbRandevuSaati.Visible = true;
        }
        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            if (lstHasta.SelectedIndex == -1)
            {
                MessageBox.Show("Önce hasta seçmelisiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbBrans.SelectedIndex == -1)
            {
                MessageBox.Show("Doktor branşı ve ardından doktor seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbDoktorlar.SelectedIndex == -1)
            {
                MessageBox.Show("Doktor seçimi yapmadınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (seciliButon == null || seciliButon.BackColor == secilmemisRenk) return;
            Randevu randevuAlan = new Randevu()
            {
                HastaAdiSoyadi = lstHasta.SelectedItem.ToString(),
                Saat = seciliButon.Text,
                DoktorAdiSoyadi = seciliDoktor.Ad + " " + seciliDoktor.Soyad,
                RandevuBransi = cmbBrans.SelectedItem.ToString(),
                DoktorID = seciliDoktor.TCKN,
                HastaID=seciliHasta.TCKN,
        };
            foreach (Randevu randevu in Randevular)
                {
                    if (randevuAlan.HastaID == randevu.HastaID && randevuAlan.DoktorID == randevu.DoktorID)
                    {
                        MessageBox.Show($"Bugün içerisinde {randevu.DoktorAdiSoyadi} adlı doktora zaten bir randevunuz var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if(randevuAlan.HastaID == randevu.HastaID && randevuAlan.Saat == randevu.Saat)
                {
                    MessageBox.Show("Aynı saatte sadece bir randevu alabilirsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                }
            Randevular.Add(randevuAlan);
            seciliDoktor.DoktorunRandevuSaatleri.Add(seciliButon.Text);

            
            MessageBox.Show($"Randevunuz alınmıştır. Randevu bilgilerinizi not etmeyi unutmayın!\n\nDoktor Adı:{randevuAlan.DoktorAdiSoyadi}\nBölüm: {randevuAlan.RandevuBransi}\n {DateTime.Now.Date:dd/MM/yyyy} - Saat: {seciliButon.Text} ", "Randevu Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            seciliButon.Enabled = false;
            seciliButon.BackColor = doluRenk;
            seciliButon = null;
            randevuAlan = null;
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Hasta> aramaSonucu = Methods.Ara(Hastalar, txtArama.Text);
            ListeyiDoldur(aramaSonucu);
        }
        private void ListeyiDoldur(List<Hasta> aramaSonucu)
        {
            lstHasta.Items.Clear();
            foreach (Hasta item in aramaSonucu)
            {
                lstHasta.Items.Add(item);
            }
        }
    }
}

