using System;

namespace HastaneOtomasyonu
{
    partial class PersonelGüncelleForm
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
            this.btnKaydet.Location = new System.Drawing.Point(22, 199);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(197, 199);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(372, 199);
            this.btnSil.TabIndex = 9;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstListe
            // 
            this.lstListe.Location = new System.Drawing.Point(495, 49);
            this.lstListe.TabIndex = 11;
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(495, 14);
            this.txtArama.TabIndex = 10;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.TabIndex = 4;
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 375);
            this.Name = "PersonelForm";
            this.Text = "Personel Ekranı";
            this.Load += new System.EventHandler(this.PersonelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
    }
}