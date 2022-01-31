namespace hareket
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ayıcık = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ayıcık)).BeginInit();
            this.SuspendLayout();
            // 
            // ayıcık
            // 
            this.ayıcık.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ayıcık.Image = ((System.Drawing.Image)(resources.GetObject("ayıcık.Image")));
            this.ayıcık.Location = new System.Drawing.Point(416, 493);
            this.ayıcık.Name = "ayıcık";
            this.ayıcık.Size = new System.Drawing.Size(95, 85);
            this.ayıcık.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ayıcık.TabIndex = 0;
            this.ayıcık.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1004, 725);
            this.Controls.Add(this.ayıcık);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NESNE HAREKETLENDIRME";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ayıcık)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ayıcık;
    }
}

