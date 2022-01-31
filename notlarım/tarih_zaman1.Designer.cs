namespace notlarım
{
    partial class tarih_zaman1
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
            this.components = new System.ComponentModel.Container();
            this.btn_anamenu = new System.Windows.Forms.Button();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.trh_sec_tm = new System.Windows.Forms.Timer(this.components);
            this.dtp_trhzmn_sec = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_anamenu
            // 
            this.btn_anamenu.BackColor = System.Drawing.Color.Red;
            this.btn_anamenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anamenu.Location = new System.Drawing.Point(846, 12);
            this.btn_anamenu.Name = "btn_anamenu";
            this.btn_anamenu.Padding = new System.Windows.Forms.Padding(5);
            this.btn_anamenu.Size = new System.Drawing.Size(150, 50);
            this.btn_anamenu.TabIndex = 2;
            this.btn_anamenu.Text = "ANA_MENU";
            this.btn_anamenu.UseVisualStyleBackColor = false;
            this.btn_anamenu.Click += new System.EventHandler(this.btn_anamenu_Click);
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.Location = new System.Drawing.Point(37, 66);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(209, 29);
            this.lbl_tarih.TabIndex = 3;
            this.lbl_tarih.Text = "Seçilmiş Tarih ...";
            // 
            // trh_sec_tm
            // 
            this.trh_sec_tm.Interval = 1000;
            this.trh_sec_tm.Tick += new System.EventHandler(this.trh_sec_tm_Tick);
            // 
            // dtp_trhzmn_sec
            // 
            this.dtp_trhzmn_sec.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dtp_trhzmn_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_trhzmn_sec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_trhzmn_sec.Location = new System.Drawing.Point(42, 168);
            this.dtp_trhzmn_sec.Name = "dtp_trhzmn_sec";
            this.dtp_trhzmn_sec.Size = new System.Drawing.Size(356, 29);
            this.dtp_trhzmn_sec.TabIndex = 4;
            this.dtp_trhzmn_sec.ValueChanged += new System.EventHandler(this.dtp_trhzmn_sec_ValueChanged);
            // 
            // tarih_zaman1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dtp_trhzmn_sec);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.btn_anamenu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "tarih_zaman1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tarih_zaman1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anamenu;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Timer trh_sec_tm;
        private System.Windows.Forms.DateTimePicker dtp_trhzmn_sec;
    }
}