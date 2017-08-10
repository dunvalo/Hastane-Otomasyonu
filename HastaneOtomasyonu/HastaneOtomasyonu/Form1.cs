using HastaOtomasyonLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HastaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Form Tanımlamaları
        Context context = new Context();
        public DoktorGüncelleForm doktorForm;
        public HemsireGüncelleForm hemsireForm;
        public HastaGüncellemeForm hastaKayıtForm;
        public PersonelGüncelleForm personelForm;
        public RandevuIslemleri randevuSistemi;
        public DosyaIslemleriForm dosyaIslemleri;
        #endregion
        void FormlariKapat()
        {
            if (personelForm != null)
                personelForm.Close();
            if (hastaKayıtForm != null)
                hastaKayıtForm.Close();
            if (hemsireForm != null)
                hemsireForm.Close();
            if (doktorForm != null)
                doktorForm.Close();
            if (randevuSistemi != null)
                randevuSistemi.Close();
        }
        private void doktorİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doktorForm == null || doktorForm.IsDisposed)
            {
                FormlariKapat();
                doktorForm = new DoktorGüncelleForm();
                doktorForm.MdiParent = this;
                doktorForm.Doktorlar = context.Doktorlar;
                doktorForm.Hemsireler = context.Hemsireler;
                doktorForm.Show();
            }
        }
        private void hemşireİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hemsireForm == null || hemsireForm.IsDisposed)
            {
                FormlariKapat();
                hemsireForm = new HemsireGüncelleForm();
                hemsireForm.MdiParent = this;
                hemsireForm.Hemsireler = context.Hemsireler;
                hemsireForm.Show();
            }
        }
        private void hastaKayıtSistemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hastaKayıtForm == null || hastaKayıtForm.IsDisposed)
            {
                FormlariKapat();
            hastaKayıtForm = new HastaGüncellemeForm();
            hastaKayıtForm.MdiParent = this;
            hastaKayıtForm.Hastalar = context.Hastalar;
            hastaKayıtForm.Show();
            }
        }
        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (personelForm == null || personelForm.IsDisposed)
            {
                FormlariKapat();
                personelForm = new PersonelGüncelleForm();
                personelForm.MdiParent = this;
                personelForm.Personeller = context.Personeller;
                personelForm.Show();
            }
        }
        private void randevuSistemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (randevuSistemi == null || randevuSistemi.IsDisposed)
            {
                FormlariKapat();
                randevuSistemi = new RandevuIslemleri();
                randevuSistemi.MdiParent = this;
                randevuSistemi.Hastalar = context.Hastalar;
                randevuSistemi.Doktorlar = context.Doktorlar;
                randevuSistemi.Randevular = context.Randevular;
                randevuSistemi.Show();
            }
        }
        private void cıktıAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dosyaIslemleri == null || dosyaIslemleri.IsDisposed)
            {
                FormlariKapat();
                dosyaIslemleri = new DosyaIslemleriForm();
                dosyaIslemleri.MdiParent = this;
                dosyaIslemleri.Doktorlar = context.Doktorlar;
                dosyaIslemleri.Randevular = context.Randevular;
                dosyaIslemleri.Show();
            }
        }
        private void dosyaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Hastane bilgilerini kaydetmek üzeresiniz\nDevam etmek istiyor musunuz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                XmlSerializer xmlHasta = new XmlSerializer(typeof(Context));
                DosyaKaydet.FileName = @"C:\Users\Wissen\Desktop\Hastane Kayıtları\Context.xml";
                TextWriter writeHasta = new StreamWriter(DosyaKaydet.FileName);
                xmlHasta.Serialize(writeHasta, context);
                writeHasta.Close();
                writeHasta.Dispose();
                MessageBox.Show("Bilgiler Başarıyla Kaydedildi", "Bilgilendirme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer xmlHasta = new XmlSerializer(typeof(Context));
            TextReader readerHasta = new StreamReader(@"C:\Users\Wissen\Desktop\Hastane Kayıtları/Context.xml");
            context = xmlHasta.Deserialize(readerHasta) as Context;
            readerHasta.Close();
            readerHasta.Dispose();
            MessageBox.Show("Hastane Otomasyon Sistemine Hoşgeldiniz", "Merhaba", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void randevularıTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Randevuları temizlemek üzeresiniz\nDevam etmek istiyor musunuz?", "Randevu Temizleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                FormlariKapat();
                foreach (Doktor doktor in context.Doktorlar)
                {
                    context.Randevular.Clear();
                    doktor.DoktorunRandevulari.Clear();
                    doktor.DoktorunRandevuSaatleri.Clear();
                }
            }
        }
    }
}
