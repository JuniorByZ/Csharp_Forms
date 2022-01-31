namespace ORTALAMA
{
    partial class giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_vize = new System.Windows.Forms.Label();
            this.lbl_final = new System.Windows.Forms.Label();
            this.lbl_ort = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_vize = new System.Windows.Forms.TextBox();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.txt_ortalama = new System.Windows.Forms.TextBox();
            this.txt_sonuc = new System.Windows.Forms.TextBox();
            this.ogrenci_grup_bilgi = new System.Windows.Forms.GroupBox();
            this.lst_ogr_bilgi_ekran = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ogrenci_grup_bilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ad.Location = new System.Drawing.Point(20, 46);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(44, 25);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "ADI";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_soyad.Location = new System.Drawing.Point(20, 81);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(85, 25);
            this.lbl_soyad.TabIndex = 1;
            this.lbl_soyad.Text = "SOYADI";
            // 
            // lbl_vize
            // 
            this.lbl_vize.AutoSize = true;
            this.lbl_vize.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_vize.Location = new System.Drawing.Point(20, 116);
            this.lbl_vize.Name = "lbl_vize";
            this.lbl_vize.Size = new System.Drawing.Size(55, 25);
            this.lbl_vize.TabIndex = 2;
            this.lbl_vize.Text = "VİZE";
            // 
            // lbl_final
            // 
            this.lbl_final.AutoSize = true;
            this.lbl_final.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_final.Location = new System.Drawing.Point(20, 151);
            this.lbl_final.Name = "lbl_final";
            this.lbl_final.Size = new System.Drawing.Size(67, 25);
            this.lbl_final.TabIndex = 3;
            this.lbl_final.Text = "FİNAL";
            // 
            // lbl_ort
            // 
            this.lbl_ort.AutoSize = true;
            this.lbl_ort.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ort.Location = new System.Drawing.Point(19, 248);
            this.lbl_ort.Name = "lbl_ort";
            this.lbl_ort.Size = new System.Drawing.Size(119, 25);
            this.lbl_ort.TabIndex = 4;
            this.lbl_ort.Text = "ORTALAMA";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sonuc.Location = new System.Drawing.Point(19, 283);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(82, 25);
            this.lbl_sonuc.TabIndex = 5;
            this.lbl_sonuc.Text = "SONUC";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.BackColor = System.Drawing.Color.Yellow;
            this.btn_hesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hesapla.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hesapla.Location = new System.Drawing.Point(20, 182);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(304, 56);
            this.btn_hesapla.TabIndex = 6;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = false;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ad.Location = new System.Drawing.Point(175, 42);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(150, 29);
            this.txt_ad.TabIndex = 7;
            this.txt_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_soyad.Location = new System.Drawing.Point(175, 77);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(150, 29);
            this.txt_soyad.TabIndex = 8;
            this.txt_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_vize
            // 
            this.txt_vize.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_vize.Location = new System.Drawing.Point(175, 112);
            this.txt_vize.Name = "txt_vize";
            this.txt_vize.Size = new System.Drawing.Size(150, 29);
            this.txt_vize.TabIndex = 9;
            this.txt_vize.Text = "00,00";
            this.txt_vize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_final
            // 
            this.txt_final.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_final.Location = new System.Drawing.Point(175, 147);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(150, 29);
            this.txt_final.TabIndex = 10;
            this.txt_final.Text = "00,00";
            this.txt_final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ortalama
            // 
            this.txt_ortalama.BackColor = System.Drawing.SystemColors.Info;
            this.txt_ortalama.Enabled = false;
            this.txt_ortalama.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ortalama.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ortalama.Location = new System.Drawing.Point(174, 244);
            this.txt_ortalama.Name = "txt_ortalama";
            this.txt_ortalama.PlaceholderText = "00,00";
            this.txt_ortalama.ReadOnly = true;
            this.txt_ortalama.Size = new System.Drawing.Size(150, 29);
            this.txt_ortalama.TabIndex = 11;
            this.txt_ortalama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sonuc
            // 
            this.txt_sonuc.BackColor = System.Drawing.SystemColors.Info;
            this.txt_sonuc.Enabled = false;
            this.txt_sonuc.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sonuc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_sonuc.Location = new System.Drawing.Point(174, 279);
            this.txt_sonuc.Name = "txt_sonuc";
            this.txt_sonuc.PlaceholderText = "Sonuç";
            this.txt_sonuc.ReadOnly = true;
            this.txt_sonuc.Size = new System.Drawing.Size(150, 29);
            this.txt_sonuc.TabIndex = 12;
            this.txt_sonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ogrenci_grup_bilgi
            // 
            this.ogrenci_grup_bilgi.BackColor = System.Drawing.Color.LightBlue;
            this.ogrenci_grup_bilgi.Controls.Add(this.txt_sonuc);
            this.ogrenci_grup_bilgi.Controls.Add(this.txt_ortalama);
            this.ogrenci_grup_bilgi.Controls.Add(this.txt_final);
            this.ogrenci_grup_bilgi.Controls.Add(this.txt_vize);
            this.ogrenci_grup_bilgi.Controls.Add(this.txt_soyad);
            this.ogrenci_grup_bilgi.Controls.Add(this.txt_ad);
            this.ogrenci_grup_bilgi.Controls.Add(this.btn_hesapla);
            this.ogrenci_grup_bilgi.Controls.Add(this.lbl_sonuc);
            this.ogrenci_grup_bilgi.Controls.Add(this.lbl_ort);
            this.ogrenci_grup_bilgi.Controls.Add(this.lbl_final);
            this.ogrenci_grup_bilgi.Controls.Add(this.lbl_vize);
            this.ogrenci_grup_bilgi.Controls.Add(this.lbl_soyad);
            this.ogrenci_grup_bilgi.Controls.Add(this.lbl_ad);
            this.ogrenci_grup_bilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrenci_grup_bilgi.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ogrenci_grup_bilgi.Location = new System.Drawing.Point(12, 16);
            this.ogrenci_grup_bilgi.Name = "ogrenci_grup_bilgi";
            this.ogrenci_grup_bilgi.Size = new System.Drawing.Size(340, 343);
            this.ogrenci_grup_bilgi.TabIndex = 13;
            this.ogrenci_grup_bilgi.TabStop = false;
            this.ogrenci_grup_bilgi.Text = "Öğrenci Giriş Bilgileri";
            // 
            // lst_ogr_bilgi_ekran
            // 
            this.lst_ogr_bilgi_ekran.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lst_ogr_bilgi_ekran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_ogr_bilgi_ekran.ColumnWidth = 1;
            this.lst_ogr_bilgi_ekran.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_ogr_bilgi_ekran.FormattingEnabled = true;
            this.lst_ogr_bilgi_ekran.ItemHeight = 25;
            this.lst_ogr_bilgi_ekran.Location = new System.Drawing.Point(358, 57);
            this.lst_ogr_bilgi_ekran.Name = "lst_ogr_bilgi_ekran";
            this.lst_ogr_bilgi_ekran.Size = new System.Drawing.Size(608, 302);
            this.lst_ogr_bilgi_ekran.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(884, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "SONUC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(740, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "ORTALAMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(649, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "FİNAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(559, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "VİZE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(441, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "SOYADI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(358, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "ADI";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1108, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_ogr_bilgi_ekran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ogrenci_grup_bilgi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "giris";
            this.Text = "ORTALAMA HESAPLAMA EKRANI";
            this.ogrenci_grup_bilgi.ResumeLayout(false);
            this.ogrenci_grup_bilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_ad;
        private Label lbl_soyad;
        private Label lbl_vize;
        private Label lbl_final;
        private Label lbl_ort;
        private Label lbl_sonuc;
        private Button btn_hesapla;
        private TextBox txt_ad;
        private TextBox txt_soyad;
        private TextBox txt_vize;
        private TextBox txt_final;
        private TextBox txt_ortalama;
        private TextBox txt_sonuc;
        private GroupBox ogrenci_grup_bilgi;
        private ListBox lst_ogr_bilgi_ekran;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}