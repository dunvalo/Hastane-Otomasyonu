namespace HastaneOtomasyonu
{
    partial class DoktorGüncelleForm
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
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstBostakiHemsireler = new System.Windows.Forms.ListBox();
            this.lstBagliHemsireler = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
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
            // txtTelefon
            // 
            this.txtTelefon.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(465, 324);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(553, 324);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(641, 324);
            this.btnSil.TabIndex = 9;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstListe
            // 
            this.lstListe.Location = new System.Drawing.Point(480, 80);
            this.lstListe.Size = new System.Drawing.Size(233, 228);
            this.lstListe.TabIndex = 11;
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(480, 50);
            this.txtArama.Size = new System.Drawing.Size(233, 24);
            this.txtArama.TabIndex = 10;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnCikar
            // 
            this.btnCikar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnCikar.Location = new System.Drawing.Point(188, 379);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(83, 37);
            this.btnCikar.TabIndex = 19;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Location = new System.Drawing.Point(188, 304);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 37);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(9, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Boştaki Hemsireler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(274, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Doktora Bağlı Hemşireler";
            // 
            // lstBostakiHemsireler
            // 
            this.lstBostakiHemsireler.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.lstBostakiHemsireler.FormattingEnabled = true;
            this.lstBostakiHemsireler.ItemHeight = 19;
            this.lstBostakiHemsireler.Location = new System.Drawing.Point(9, 217);
            this.lstBostakiHemsireler.Name = "lstBostakiHemsireler";
            this.lstBostakiHemsireler.Size = new System.Drawing.Size(173, 194);
            this.lstBostakiHemsireler.TabIndex = 15;
            // 
            // lstBagliHemsireler
            // 
            this.lstBagliHemsireler.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.lstBagliHemsireler.FormattingEnabled = true;
            this.lstBagliHemsireler.ItemHeight = 19;
            this.lstBagliHemsireler.Location = new System.Drawing.Point(277, 217);
            this.lstBagliHemsireler.Name = "lstBagliHemsireler";
            this.lstBagliHemsireler.Size = new System.Drawing.Size(173, 194);
            this.lstBagliHemsireler.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(477, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Doktorlar";
            // 
            // DoktorGüncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 439);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstBostakiHemsireler);
            this.Controls.Add(this.lstBagliHemsireler);
            this.Name = "DoktorGüncelleForm";
            this.Text = "Doktor İşlemleri";
            this.Load += new System.EventHandler(this.DoktorForm_Load);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cmbBrans, 0);
            this.Controls.SetChildIndex(this.nMaas, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lstListe, 0);
            this.Controls.SetChildIndex(this.txtArama, 0);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.Controls.SetChildIndex(this.txtSoyad, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtTelefon, 0);
            this.Controls.SetChildIndex(this.dtpDogumTarihi, 0);
            this.Controls.SetChildIndex(this.cmbCinsiyet, 0);
            this.Controls.SetChildIndex(this.btnKaydet, 0);
            this.Controls.SetChildIndex(this.btnGuncelle, 0);
            this.Controls.SetChildIndex(this.btnSil, 0);
            this.Controls.SetChildIndex(this.lstBagliHemsireler, 0);
            this.Controls.SetChildIndex(this.lstBostakiHemsireler, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.btnEkle, 0);
            this.Controls.SetChildIndex(this.btnCikar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstBostakiHemsireler;
        private System.Windows.Forms.ListBox lstBagliHemsireler;
        private System.Windows.Forms.Label label11;
    }
}