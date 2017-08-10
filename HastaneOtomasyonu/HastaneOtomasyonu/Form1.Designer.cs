namespace HastaneOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doktorİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKayıtSistemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuSistemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuSistemiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.randevularıTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.DosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cıktıAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorİşlemleriToolStripMenuItem,
            this.hemşireİşlemleriToolStripMenuItem,
            this.hastaİşlemleriToolStripMenuItem,
            this.hastaKayıtSistemiToolStripMenuItem,
            this.randevuSistemiToolStripMenuItem,
            this.dosyaİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doktorİşlemleriToolStripMenuItem
            // 
            this.doktorİşlemleriToolStripMenuItem.Name = "doktorİşlemleriToolStripMenuItem";
            this.doktorİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.doktorİşlemleriToolStripMenuItem.Text = "&Doktor İşlemleri";
            this.doktorİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.doktorİşlemleriToolStripMenuItem_Click);
            // 
            // hemşireİşlemleriToolStripMenuItem
            // 
            this.hemşireİşlemleriToolStripMenuItem.Name = "hemşireİşlemleriToolStripMenuItem";
            this.hemşireİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.hemşireİşlemleriToolStripMenuItem.Text = "&Hemşire İşlemleri";
            this.hemşireİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.hemşireİşlemleriToolStripMenuItem_Click);
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.hastaİşlemleriToolStripMenuItem.Text = "&Personel İşlemleri";
            this.hastaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.personelİşlemleriToolStripMenuItem_Click);
            // 
            // hastaKayıtSistemiToolStripMenuItem
            // 
            this.hastaKayıtSistemiToolStripMenuItem.Name = "hastaKayıtSistemiToolStripMenuItem";
            this.hastaKayıtSistemiToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.hastaKayıtSistemiToolStripMenuItem.Text = "Hasta İşlemleri";
            this.hastaKayıtSistemiToolStripMenuItem.Click += new System.EventHandler(this.hastaKayıtSistemiToolStripMenuItem_Click);
            // 
            // randevuSistemiToolStripMenuItem
            // 
            this.randevuSistemiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuSistemiToolStripMenuItem1,
            this.randevularıTemizleToolStripMenuItem});
            this.randevuSistemiToolStripMenuItem.Name = "randevuSistemiToolStripMenuItem";
            this.randevuSistemiToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.randevuSistemiToolStripMenuItem.Text = "&Randevu Sistemi";
            // 
            // randevuSistemiToolStripMenuItem1
            // 
            this.randevuSistemiToolStripMenuItem1.Name = "randevuSistemiToolStripMenuItem1";
            this.randevuSistemiToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.randevuSistemiToolStripMenuItem1.Text = "&Randevu Sistemi";
            this.randevuSistemiToolStripMenuItem1.Click += new System.EventHandler(this.randevuSistemiToolStripMenuItem_Click);
            // 
            // randevularıTemizleToolStripMenuItem
            // 
            this.randevularıTemizleToolStripMenuItem.Name = "randevularıTemizleToolStripMenuItem";
            this.randevularıTemizleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.randevularıTemizleToolStripMenuItem.Text = "Randevuları &Temizle";
            this.randevularıTemizleToolStripMenuItem.Click += new System.EventHandler(this.randevularıTemizleToolStripMenuItem_Click);
            // 
            // dosyaİşlemleriToolStripMenuItem
            // 
            this.dosyaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.cıktıAlToolStripMenuItem});
            this.dosyaİşlemleriToolStripMenuItem.Name = "dosyaİşlemleriToolStripMenuItem";
            this.dosyaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.dosyaİşlemleriToolStripMenuItem.Text = "Dosya &İşlemleri";
            // 
            // DosyaAc
            // 
            this.DosyaAc.FileName = "openFileDialog1";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.dosyaİşlemleriToolStripMenuItem_Click);
            // 
            // cıktıAlToolStripMenuItem
            // 
            this.cıktıAlToolStripMenuItem.Name = "cıktıAlToolStripMenuItem";
            this.cıktıAlToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cıktıAlToolStripMenuItem.Text = "Cıktı Al";
            this.cıktıAlToolStripMenuItem.Click += new System.EventHandler(this.cıktıAlToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 388);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Giriş Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doktorİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKayıtSistemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuSistemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog DosyaKaydet;
        private System.Windows.Forms.OpenFileDialog DosyaAc;
        private System.Windows.Forms.ToolStripMenuItem randevuSistemiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem randevularıTemizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cıktıAlToolStripMenuItem;
    }
}

