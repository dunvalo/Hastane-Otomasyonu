namespace HastaneOtomasyonu
{
    partial class DosyaIslemleriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DosyaIslemleriForm));
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.lblDoktorIsmi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.btnOnizleme = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lstRandevu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnAyarlar.Location = new System.Drawing.Point(124, 49);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(75, 46);
            this.btnAyarlar.TabIndex = 18;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // lblDoktorIsmi
            // 
            this.lblDoktorIsmi.AutoSize = true;
            this.lblDoktorIsmi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.lblDoktorIsmi.Location = new System.Drawing.Point(17, 109);
            this.lblDoktorIsmi.Name = "lblDoktorIsmi";
            this.lblDoktorIsmi.Size = new System.Drawing.Size(33, 16);
            this.lblDoktorIsmi.TabIndex = 17;
            this.lblDoktorIsmi.Text = ".....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Doktor Seç";
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktorlar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(96, 10);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(208, 24);
            this.cmbDoktorlar.TabIndex = 15;
            this.cmbDoktorlar.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorlar_SelectedIndexChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // btnYazdır
            // 
            this.btnYazdır.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnYazdır.Location = new System.Drawing.Point(15, 49);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(75, 46);
            this.btnYazdır.TabIndex = 20;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // btnOnizleme
            // 
            this.btnOnizleme.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnOnizleme.Location = new System.Drawing.Point(229, 49);
            this.btnOnizleme.Name = "btnOnizleme";
            this.btnOnizleme.Size = new System.Drawing.Size(75, 46);
            this.btnOnizleme.TabIndex = 19;
            this.btnOnizleme.Text = "Önizleme";
            this.btnOnizleme.UseVisualStyleBackColor = true;
            this.btnOnizleme.Click += new System.EventHandler(this.btnOnizleme_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lstRandevu
            // 
            this.lstRandevu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.lstRandevu.FormattingEnabled = true;
            this.lstRandevu.ItemHeight = 16;
            this.lstRandevu.Location = new System.Drawing.Point(12, 128);
            this.lstRandevu.Name = "lstRandevu";
            this.lstRandevu.Size = new System.Drawing.Size(479, 356);
            this.lstRandevu.TabIndex = 21;
            // 
            // DosyaIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(497, 506);
            this.Controls.Add(this.lstRandevu);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.lblDoktorIsmi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDoktorlar);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.btnOnizleme);
            this.Name = "DosyaIslemleriForm";
            this.Text = "DosyaIslemleriForm";
            this.Load += new System.EventHandler(this.DosyaIslemleriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Label lblDoktorIsmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.Button btnOnizleme;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ListBox lstRandevu;
    }
}