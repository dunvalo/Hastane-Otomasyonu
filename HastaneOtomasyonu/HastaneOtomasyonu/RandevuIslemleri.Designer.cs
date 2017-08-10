namespace HastaneOtomasyonu
{
    partial class RandevuIslemleri
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
            this.gbHastaBilgi = new System.Windows.Forms.GroupBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lstHasta = new System.Windows.Forms.ListBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn1415 = new System.Windows.Forms.Button();
            this.btn1430 = new System.Windows.Forms.Button();
            this.btn1445 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn1115 = new System.Windows.Forms.Button();
            this.btn1130 = new System.Windows.Forms.Button();
            this.btn1145 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn1315 = new System.Windows.Forms.Button();
            this.btn1330 = new System.Windows.Forms.Button();
            this.btn1345 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn1045 = new System.Windows.Forms.Button();
            this.btn915 = new System.Windows.Forms.Button();
            this.btn1030 = new System.Windows.Forms.Button();
            this.btn930 = new System.Windows.Forms.Button();
            this.btn1015 = new System.Windows.Forms.Button();
            this.btn945 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.gbRandevu = new System.Windows.Forms.GroupBox();
            this.btnRandevuEkle = new System.Windows.Forms.Button();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbRandevuSaati = new System.Windows.Forms.GroupBox();
            this.gbHastaBilgi.SuspendLayout();
            this.gbRandevu.SuspendLayout();
            this.gbRandevuSaati.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHastaBilgi
            // 
            this.gbHastaBilgi.Controls.Add(this.cmbCinsiyet);
            this.gbHastaBilgi.Controls.Add(this.dtpDogumTarihi);
            this.gbHastaBilgi.Controls.Add(this.lstHasta);
            this.gbHastaBilgi.Controls.Add(this.txtArama);
            this.gbHastaBilgi.Controls.Add(this.txtSoyad);
            this.gbHastaBilgi.Controls.Add(this.txtAd);
            this.gbHastaBilgi.Controls.Add(this.label4);
            this.gbHastaBilgi.Controls.Add(this.label3);
            this.gbHastaBilgi.Controls.Add(this.label2);
            this.gbHastaBilgi.Controls.Add(this.label1);
            this.gbHastaBilgi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.gbHastaBilgi.Location = new System.Drawing.Point(12, 12);
            this.gbHastaBilgi.Name = "gbHastaBilgi";
            this.gbHastaBilgi.Size = new System.Drawing.Size(377, 291);
            this.gbHastaBilgi.TabIndex = 0;
            this.gbHastaBilgi.TabStop = false;
            this.gbHastaBilgi.Text = "Hasta Bilgi";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.Enabled = false;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(88, 130);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(123, 24);
            this.cmbCinsiyet.TabIndex = 11;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Enabled = false;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(88, 94);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(123, 24);
            this.dtpDogumTarihi.TabIndex = 10;
            // 
            // lstHasta
            // 
            this.lstHasta.FormattingEnabled = true;
            this.lstHasta.ItemHeight = 16;
            this.lstHasta.Location = new System.Drawing.Point(217, 48);
            this.lstHasta.Name = "lstHasta";
            this.lstHasta.Size = new System.Drawing.Size(147, 164);
            this.lstHasta.TabIndex = 9;
            this.lstHasta.SelectedIndexChanged += new System.EventHandler(this.lstHasta_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(217, 19);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(147, 24);
            this.txtArama.TabIndex = 8;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(88, 58);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(123, 24);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(88, 22);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(123, 24);
            this.txtAd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.LightGreen;
            this.btn14.Location = new System.Drawing.Point(6, 161);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(60, 23);
            this.btn14.TabIndex = 95;
            this.btn14.Text = "14:00";
            this.btn14.UseVisualStyleBackColor = false;
            // 
            // btn1415
            // 
            this.btn1415.BackColor = System.Drawing.Color.LightGreen;
            this.btn1415.Location = new System.Drawing.Point(66, 161);
            this.btn1415.Name = "btn1415";
            this.btn1415.Size = new System.Drawing.Size(60, 23);
            this.btn1415.TabIndex = 94;
            this.btn1415.Text = "14:15";
            this.btn1415.UseVisualStyleBackColor = false;
            // 
            // btn1430
            // 
            this.btn1430.BackColor = System.Drawing.Color.LightGreen;
            this.btn1430.Location = new System.Drawing.Point(126, 161);
            this.btn1430.Name = "btn1430";
            this.btn1430.Size = new System.Drawing.Size(60, 23);
            this.btn1430.TabIndex = 93;
            this.btn1430.Text = "14:30";
            this.btn1430.UseVisualStyleBackColor = false;
            // 
            // btn1445
            // 
            this.btn1445.BackColor = System.Drawing.Color.LightGreen;
            this.btn1445.Location = new System.Drawing.Point(186, 161);
            this.btn1445.Name = "btn1445";
            this.btn1445.Size = new System.Drawing.Size(60, 23);
            this.btn1445.TabIndex = 92;
            this.btn1445.Text = "14:45";
            this.btn1445.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.LightGreen;
            this.btn11.Location = new System.Drawing.Point(6, 91);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(60, 23);
            this.btn11.TabIndex = 91;
            this.btn11.Text = "11:00";
            this.btn11.UseVisualStyleBackColor = false;
            // 
            // btn1115
            // 
            this.btn1115.BackColor = System.Drawing.Color.LightGreen;
            this.btn1115.Location = new System.Drawing.Point(66, 91);
            this.btn1115.Name = "btn1115";
            this.btn1115.Size = new System.Drawing.Size(60, 23);
            this.btn1115.TabIndex = 90;
            this.btn1115.Text = "11:15";
            this.btn1115.UseVisualStyleBackColor = false;
            // 
            // btn1130
            // 
            this.btn1130.BackColor = System.Drawing.Color.LightGreen;
            this.btn1130.Location = new System.Drawing.Point(126, 91);
            this.btn1130.Name = "btn1130";
            this.btn1130.Size = new System.Drawing.Size(60, 23);
            this.btn1130.TabIndex = 89;
            this.btn1130.Text = "11:30";
            this.btn1130.UseVisualStyleBackColor = false;
            // 
            // btn1145
            // 
            this.btn1145.BackColor = System.Drawing.Color.LightGreen;
            this.btn1145.Location = new System.Drawing.Point(186, 91);
            this.btn1145.Name = "btn1145";
            this.btn1145.Size = new System.Drawing.Size(60, 23);
            this.btn1145.TabIndex = 88;
            this.btn1145.Text = "11:45";
            this.btn1145.UseVisualStyleBackColor = false;
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.LightGreen;
            this.btn13.Location = new System.Drawing.Point(6, 132);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(60, 23);
            this.btn13.TabIndex = 87;
            this.btn13.Text = "13:00";
            this.btn13.UseVisualStyleBackColor = false;
            // 
            // btn1315
            // 
            this.btn1315.BackColor = System.Drawing.Color.LightGreen;
            this.btn1315.Location = new System.Drawing.Point(66, 132);
            this.btn1315.Name = "btn1315";
            this.btn1315.Size = new System.Drawing.Size(60, 23);
            this.btn1315.TabIndex = 86;
            this.btn1315.Text = "13:15";
            this.btn1315.UseVisualStyleBackColor = false;
            // 
            // btn1330
            // 
            this.btn1330.BackColor = System.Drawing.Color.LightGreen;
            this.btn1330.Location = new System.Drawing.Point(126, 132);
            this.btn1330.Name = "btn1330";
            this.btn1330.Size = new System.Drawing.Size(60, 23);
            this.btn1330.TabIndex = 85;
            this.btn1330.Text = "13:30";
            this.btn1330.UseVisualStyleBackColor = false;
            // 
            // btn1345
            // 
            this.btn1345.BackColor = System.Drawing.Color.LightGreen;
            this.btn1345.Location = new System.Drawing.Point(186, 132);
            this.btn1345.Name = "btn1345";
            this.btn1345.Size = new System.Drawing.Size(60, 23);
            this.btn1345.TabIndex = 84;
            this.btn1345.Text = "13:45";
            this.btn1345.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.LightGreen;
            this.btn9.Location = new System.Drawing.Point(6, 33);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 23);
            this.btn9.TabIndex = 76;
            this.btn9.Text = "09:00";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn1045
            // 
            this.btn1045.BackColor = System.Drawing.Color.LightGreen;
            this.btn1045.Location = new System.Drawing.Point(186, 62);
            this.btn1045.Name = "btn1045";
            this.btn1045.Size = new System.Drawing.Size(60, 23);
            this.btn1045.TabIndex = 83;
            this.btn1045.Text = "10:45";
            this.btn1045.UseVisualStyleBackColor = false;
            // 
            // btn915
            // 
            this.btn915.BackColor = System.Drawing.Color.LightGreen;
            this.btn915.Location = new System.Drawing.Point(66, 33);
            this.btn915.Name = "btn915";
            this.btn915.Size = new System.Drawing.Size(60, 23);
            this.btn915.TabIndex = 77;
            this.btn915.Text = "09:15";
            this.btn915.UseVisualStyleBackColor = false;
            // 
            // btn1030
            // 
            this.btn1030.BackColor = System.Drawing.Color.LightGreen;
            this.btn1030.Location = new System.Drawing.Point(126, 62);
            this.btn1030.Name = "btn1030";
            this.btn1030.Size = new System.Drawing.Size(60, 23);
            this.btn1030.TabIndex = 82;
            this.btn1030.Text = "10:30";
            this.btn1030.UseVisualStyleBackColor = false;
            // 
            // btn930
            // 
            this.btn930.BackColor = System.Drawing.Color.LightGreen;
            this.btn930.Location = new System.Drawing.Point(126, 33);
            this.btn930.Name = "btn930";
            this.btn930.Size = new System.Drawing.Size(60, 23);
            this.btn930.TabIndex = 78;
            this.btn930.Text = "09:30";
            this.btn930.UseVisualStyleBackColor = false;
            // 
            // btn1015
            // 
            this.btn1015.BackColor = System.Drawing.Color.LightGreen;
            this.btn1015.Location = new System.Drawing.Point(66, 62);
            this.btn1015.Name = "btn1015";
            this.btn1015.Size = new System.Drawing.Size(60, 23);
            this.btn1015.TabIndex = 81;
            this.btn1015.Text = "10:15";
            this.btn1015.UseVisualStyleBackColor = false;
            // 
            // btn945
            // 
            this.btn945.BackColor = System.Drawing.Color.LightGreen;
            this.btn945.Location = new System.Drawing.Point(186, 33);
            this.btn945.Name = "btn945";
            this.btn945.Size = new System.Drawing.Size(60, 23);
            this.btn945.TabIndex = 79;
            this.btn945.Text = "09:45";
            this.btn945.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.LightGreen;
            this.btn10.Location = new System.Drawing.Point(6, 62);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(60, 23);
            this.btn10.TabIndex = 80;
            this.btn10.Text = "10:00";
            this.btn10.UseVisualStyleBackColor = false;
            // 
            // gbRandevu
            // 
            this.gbRandevu.Controls.Add(this.btnRandevuEkle);
            this.gbRandevu.Controls.Add(this.cmbDoktorlar);
            this.gbRandevu.Controls.Add(this.label5);
            this.gbRandevu.Controls.Add(this.cmbBrans);
            this.gbRandevu.Controls.Add(this.label6);
            this.gbRandevu.Controls.Add(this.gbRandevuSaati);
            this.gbRandevu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.gbRandevu.Location = new System.Drawing.Point(395, 15);
            this.gbRandevu.Name = "gbRandevu";
            this.gbRandevu.Size = new System.Drawing.Size(414, 288);
            this.gbRandevu.TabIndex = 1;
            this.gbRandevu.TabStop = false;
            this.gbRandevu.Text = "Randevu İşlemleri";
            this.gbRandevu.Visible = false;
            // 
            // btnRandevuEkle
            // 
            this.btnRandevuEkle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.btnRandevuEkle.Location = new System.Drawing.Point(289, 75);
            this.btnRandevuEkle.Name = "btnRandevuEkle";
            this.btnRandevuEkle.Size = new System.Drawing.Size(101, 40);
            this.btnRandevuEkle.TabIndex = 5;
            this.btnRandevuEkle.Text = "Randevu Ekle";
            this.btnRandevuEkle.UseVisualStyleBackColor = true;
            this.btnRandevuEkle.Click += new System.EventHandler(this.btnRandevuEkle_Click);
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(263, 24);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(145, 24);
            this.cmbDoktorlar.TabIndex = 4;
            this.cmbDoktorlar.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorlar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(210, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Doktor";
            // 
            // cmbBrans
            // 
            this.cmbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(59, 24);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(145, 24);
            this.cmbBrans.TabIndex = 2;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Branş";
            // 
            // gbRandevuSaati
            // 
            this.gbRandevuSaati.Controls.Add(this.btn14);
            this.gbRandevuSaati.Controls.Add(this.btn1030);
            this.gbRandevuSaati.Controls.Add(this.btn10);
            this.gbRandevuSaati.Controls.Add(this.btn1415);
            this.gbRandevuSaati.Controls.Add(this.btn945);
            this.gbRandevuSaati.Controls.Add(this.btn1015);
            this.gbRandevuSaati.Controls.Add(this.btn1430);
            this.gbRandevuSaati.Controls.Add(this.btn930);
            this.gbRandevuSaati.Controls.Add(this.btn915);
            this.gbRandevuSaati.Controls.Add(this.btn1445);
            this.gbRandevuSaati.Controls.Add(this.btn1045);
            this.gbRandevuSaati.Controls.Add(this.btn11);
            this.gbRandevuSaati.Controls.Add(this.btn9);
            this.gbRandevuSaati.Controls.Add(this.btn1345);
            this.gbRandevuSaati.Controls.Add(this.btn1115);
            this.gbRandevuSaati.Controls.Add(this.btn1330);
            this.gbRandevuSaati.Controls.Add(this.btn1315);
            this.gbRandevuSaati.Controls.Add(this.btn1130);
            this.gbRandevuSaati.Controls.Add(this.btn13);
            this.gbRandevuSaati.Controls.Add(this.btn1145);
            this.gbRandevuSaati.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.gbRandevuSaati.Location = new System.Drawing.Point(9, 58);
            this.gbRandevuSaati.Name = "gbRandevuSaati";
            this.gbRandevuSaati.Size = new System.Drawing.Size(264, 195);
            this.gbRandevuSaati.TabIndex = 0;
            this.gbRandevuSaati.TabStop = false;
            this.gbRandevuSaati.Text = "Randevu Saati";
            this.gbRandevuSaati.Visible = false;
            // 
            // RandevuIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(820, 323);
            this.Controls.Add(this.gbRandevu);
            this.Controls.Add(this.gbHastaBilgi);
            this.Name = "RandevuIslemleri";
            this.Text = "RandevuIslemleri";
            this.Load += new System.EventHandler(this.RandevuIslemleri_Load);
            this.gbHastaBilgi.ResumeLayout(false);
            this.gbHastaBilgi.PerformLayout();
            this.gbRandevu.ResumeLayout(false);
            this.gbRandevu.PerformLayout();
            this.gbRandevuSaati.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHastaBilgi;
        private System.Windows.Forms.ListBox lstHasta;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.GroupBox gbRandevu;
        private System.Windows.Forms.Button btnRandevuEkle;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbRandevuSaati;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn1415;
        private System.Windows.Forms.Button btn1430;
        private System.Windows.Forms.Button btn1445;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn1115;
        private System.Windows.Forms.Button btn1130;
        private System.Windows.Forms.Button btn1145;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn1315;
        private System.Windows.Forms.Button btn1330;
        private System.Windows.Forms.Button btn1345;
        private System.Windows.Forms.Button btn1045;
        private System.Windows.Forms.Button btn1030;
        private System.Windows.Forms.Button btn1015;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn945;
        private System.Windows.Forms.Button btn930;
        private System.Windows.Forms.Button btn915;
        private System.Windows.Forms.Button btn9;
    }
}