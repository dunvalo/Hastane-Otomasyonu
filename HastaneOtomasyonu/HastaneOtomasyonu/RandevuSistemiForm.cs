using HastaOtomasyonLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
            Saatler = Methods.SaatleriGetir();
        }
        Color seciliRenk = Color.DarkSalmon;
        Color secilmemisRenk = Color.LightGreen;
        Color doluRenk = Color.LightGray;
        public List<Hasta> Hastalar { get; set; }
        public List<Doktor> Doktorlar { get; set; }
        public List<Randevu> Randevular { get; set; }
        public List<string> Saatler { get; set; }
        public Button SeciliButton { get; set; }
        public Hasta SeciliHasta { get; set; }

        private void lstHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHasta.SelectedIndex == -1)
            {
                SeciliHasta = null;
                gbRandevu.Visible = false;
                return;
            }

            SeciliHasta = lstHasta.SelectedItem as Hasta;

            txtAd.Text = SeciliHasta.Ad;
            txtSoyad.Text = SeciliHasta.Soyad;
            txtTCKN.Text = SeciliHasta.TCKN;
            dtpDogumTarihi.Value = SeciliHasta.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)SeciliHasta.Cinsiyet;

            gbRandevu.Visible = true;
        }

        private void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(SaglıkBranslar)));
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));

            lstHasta.Items.Clear();
            foreach (Hasta item in Hastalar)
            {
                lstHasta.Items.Add(item);
            }


            ButonDoldur();
        }
        private void ButonDoldur()
        {
            gbRandevuSaati.Controls.Clear();
            for (int i = 0; i < 30; i++)
            {
                Button saatButon = new Button()
                {
                    BackColor = secilmemisRenk,
                    Text = Saatler[i],
                    Name = "btnSaat_" + i,
                    Size = new Size(60, 30)
                };
                saatButon.Click += SaatButon_Click;
                gbRandevuSaati.Controls.Add(saatButon);
            }
        }


        private void SaatButon_Click(object sender, EventArgs e)
        {
            SeciliButton = sender as Button;

            ButonSec(SeciliButton);
        }

        private void ButonSec(Button seciliButton)
        {
            foreach (Button item in gbRandevuSaati.Controls)
            {
                if (item.Name == seciliButton.Name)
                    seciliButton.BackColor = seciliRenk;
                else if (item.Enabled == true)
                    item.BackColor = secilmemisRenk;
            }
        }
    }
}

