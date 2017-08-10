using HastaOtomasyonLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class DosyaIslemleriForm : Form
    {
        public DosyaIslemleriForm()
        {
            InitializeComponent();
        }
        private void DosyaIslemleriForm_Load(object sender, EventArgs e)
        {
            cmbDoktorlar.Items.AddRange(Doktorlar.ToArray());
        }
        int toplamsayfa = 1;
        int sayfano = 1;
        public List<Doktor> Doktorlar { get; set; }
        public List<Randevu> Randevular { get; set; }
        private Doktor seciliDoktor;

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            DialogResult yazdirmaIslemi;
            yazdirmaIslemi = printDialog1.ShowDialog();
            if (yazdirmaIslemi == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.ShowDialog();
            PageSettings ayarlar = this.pageSetupDialog1.PageSettings;
            this.printDocument1.DefaultPageSettings = ayarlar;
        }
        private void btnOnizleme_Click(object sender, EventArgs e)
        {
            if (cmbDoktorlar.SelectedIndex == -1)
            {
                MessageBox.Show("Doktor seçimi yapmadınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //yazi fontumuzu ayarliyoruz
            Graphics gr = e.Graphics;

            //yazi tipi Trebuchet MS, boyutu 30 ve bold karakterlerle yazilicak
            Font f = new Font("Trebuchet MS", 30, FontStyle.Bold);

            //yazdirma alanimizin ozellıklerını belirliyoruz
            Rectangle yazdirma_alani = new Rectangle();
            yazdirma_alani.X = this.printDocument1.DefaultPageSettings.Margins.Left;
            yazdirma_alani.Y = this.printDocument1.DefaultPageSettings.Margins.Top;
            yazdirma_alani.Width = this.printDocument1.DefaultPageSettings.PaperSize.Width - this.printDocument1.DefaultPageSettings.Margins.Left - this.printDocument1.DefaultPageSettings.Margins.Right;
            yazdirma_alani.Height = this.printDocument1.DefaultPageSettings.PaperSize.Height - this.printDocument1.DefaultPageSettings.Margins.Top - this.printDocument1.DefaultPageSettings.Margins.Bottom;

            if (this.printDocument1.DefaultPageSettings.Landscape)
            {

                int tempwidth = yazdirma_alani.Width;
                yazdirma_alani.Width = yazdirma_alani.Height;
                yazdirma_alani.Height = tempwidth;
            }
            //yazdirma alaninin kenarındaki cizgilerin ozelliklerini ayarliyoruz
            int y = 360;
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Pink);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            e.Graphics.DrawString($"{cmbDoktorlar.SelectedItem}\nHASTA RANDEVU FORMU", myFont, sbrush, 200, 120);

            e.Graphics.DrawLine(myPen, 120, 320, 750, 320);

            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;

            myFont = new Font("Calibri", 12, FontStyle.Bold);
            e.Graphics.DrawString("Saat", myFont, sbrush, 140, 328);
            e.Graphics.DrawString("Tc No", myFont, sbrush, 340, 328);
            e.Graphics.DrawString("Adı Soyadı", myFont, sbrush, 540, 328);
            lstRandevu.Items.Clear();
            if (cmbDoktorlar.SelectedIndex == -1) return;
            foreach (Randevu item in seciliDoktor.DoktorunRandevulari)
            {
                e.Graphics.DrawString(item.Saat, myFont, sbrush, 180, y, myStringFormat);
                e.Graphics.DrawString(item.HastaID, myFont, sbrush, 420, y, myStringFormat);
                e.Graphics.DrawString(item.HastaAdiSoyadi, myFont, sbrush, 540, y);
                y += 50;
            }
            gr.DrawRectangle(myPen, yazdirma_alani);
            // gr.DrawString(this.TextBox1.Text + " : " + sayfano, f, Brushes.Black, (yazdirma_alani.X + 10), (yazdirma_alani.Y + 20));
            sayfano++;

            if (sayfano < toplamsayfa)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }
        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDoktorIsmi.Text = cmbDoktorlar.SelectedItem.ToString();
            seciliDoktor = cmbDoktorlar.SelectedItem as Doktor;
            seciliDoktor.DoktorunRandevulari = Randevular.Where(item => seciliDoktor.TCKN == item.DoktorID).ToList();
            seciliDoktor.DoktorunRandevulari.Sort(delegate (Randevu x, Randevu y)
            {
                if (x.Saat == null && y.Saat == null) return 0;
                else if (x.Saat == null) return -1;
                else if (y.Saat == null) return 1;
                else return x.Saat.CompareTo(y.Saat);
            });

            ListeyiDoldur();
        }
        private void ListeyiDoldur()
        {
            lstRandevu.Items.Clear();
            foreach (Randevu item in seciliDoktor.DoktorunRandevulari)
            {
                lstRandevu.Items.Add(item);
            }
        }
    }
}
