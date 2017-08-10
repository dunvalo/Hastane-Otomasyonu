namespace HastaneOtomasyonu
{
    partial class HastaGüncellemeForm
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
            this.SuspendLayout();
            // 
            // txtSoyad
            // 
            this.txtSoyad.TabIndex = 1;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.TabIndex = 7;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstListe
            // 
            this.lstListe.TabIndex = 9;
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.TabIndex = 8;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // HastaGüncellemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 332);
            this.Name = "HastaGüncellemeForm";
            this.Text = "Hasta Kayıt İşlemleri";
            this.Load += new System.EventHandler(this.HastaKayıtForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}