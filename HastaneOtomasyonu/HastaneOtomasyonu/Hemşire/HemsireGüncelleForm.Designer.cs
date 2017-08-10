namespace HastaneOtomasyonu
{
    partial class HemsireGüncelleForm
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
            ((System.ComponentModel.ISupportInitialize)(this.nMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // nMaas
            // 
            this.nMaas.TabIndex = 6;
            // 
            // cmbBrans
            // 
            this.cmbBrans.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.TabIndex = 1;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.TabIndex = 9;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstListe
            // 
            this.lstListe.TabIndex = 11;
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.TabIndex = 10;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(323, 59);
            this.txtTelefon.TabIndex = 4;
            // 
            // HemsireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 332);
            this.Name = "HemsireForm";
            this.Text = "Hemşire İşlemleri";
            this.Load += new System.EventHandler(this.HemsireForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}