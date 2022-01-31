namespace notlarım
{
    partial class ana_form
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_trhzmn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(910, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Padding = new System.Windows.Forms.Padding(5);
            this.btn_kapat.Size = new System.Drawing.Size(90, 50);
            this.btn_kapat.TabIndex = 0;
            this.btn_kapat.Text = "KAPAT";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_trhzmn
            // 
            this.btn_trhzmn.BackColor = System.Drawing.Color.Red;
            this.btn_trhzmn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_trhzmn.Location = new System.Drawing.Point(12, 12);
            this.btn_trhzmn.Name = "btn_trhzmn";
            this.btn_trhzmn.Padding = new System.Windows.Forms.Padding(5);
            this.btn_trhzmn.Size = new System.Drawing.Size(185, 50);
            this.btn_trhzmn.TabIndex = 2;
            this.btn_trhzmn.Text = "TARIH_ZAMAN_1";
            this.btn_trhzmn.UseVisualStyleBackColor = false;
            this.btn_trhzmn.Click += new System.EventHandler(this.btn_trhzmn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 68);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(185, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "TARIH_ZAMAN_2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ana_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_trhzmn);
            this.Controls.Add(this.btn_kapat);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ana_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTLARIM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_trhzmn;
        private System.Windows.Forms.Button button1;
    }
}

