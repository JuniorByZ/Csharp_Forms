namespace notlarım
{
    partial class tarih_zaman
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
            this.lbl_trhzmn = new System.Windows.Forms.Label();
            this.trhzmn_tmr = new System.Windows.Forms.Timer(this.components);
            this.lbl_trh = new System.Windows.Forms.Label();
            this.lbl_zmn = new System.Windows.Forms.Label();
            this.dtp_trhsec = new System.Windows.Forms.DateTimePicker();
            this.dtp_zmnsec = new System.Windows.Forms.DateTimePicker();
            this.lbl_dtp_zmn = new System.Windows.Forms.Label();
            this.lbl_dtp_trh = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.btn_anamenu.TabIndex = 1;
            this.btn_anamenu.Text = "ANA_MENU";
            this.btn_anamenu.UseVisualStyleBackColor = false;
            this.btn_anamenu.Click += new System.EventHandler(this.btn_anamenu_Click);
            // 
            // lbl_trhzmn
            // 
            this.lbl_trhzmn.AutoSize = true;
            this.lbl_trhzmn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_trhzmn.Location = new System.Drawing.Point(6, 22);
            this.lbl_trhzmn.Name = "lbl_trhzmn";
            this.lbl_trhzmn.Size = new System.Drawing.Size(128, 24);
            this.lbl_trhzmn.TabIndex = 2;
            this.lbl_trhzmn.Text = "Tarih/Zaman";
            // 
            // trhzmn_tmr
            // 
            this.trhzmn_tmr.Interval = 1000;
            this.trhzmn_tmr.Tick += new System.EventHandler(this.trhzmn_tmr_Tick);
            // 
            // lbl_trh
            // 
            this.lbl_trh.AutoSize = true;
            this.lbl_trh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_trh.Location = new System.Drawing.Point(6, 46);
            this.lbl_trh.Name = "lbl_trh";
            this.lbl_trh.Size = new System.Drawing.Size(58, 24);
            this.lbl_trh.TabIndex = 3;
            this.lbl_trh.Text = "Tarih";
            // 
            // lbl_zmn
            // 
            this.lbl_zmn.AutoSize = true;
            this.lbl_zmn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_zmn.Location = new System.Drawing.Point(6, 70);
            this.lbl_zmn.Name = "lbl_zmn";
            this.lbl_zmn.Size = new System.Drawing.Size(74, 24);
            this.lbl_zmn.TabIndex = 4;
            this.lbl_zmn.Text = "Zaman";
            // 
            // dtp_trhsec
            // 
            this.dtp_trhsec.CalendarMonthBackground = System.Drawing.Color.Moccasin;
            this.dtp_trhsec.CalendarTitleBackColor = System.Drawing.Color.SandyBrown;
            this.dtp_trhsec.Checked = false;
            this.dtp_trhsec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_trhsec.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dtp_trhsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_trhsec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_trhsec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_trhsec.Location = new System.Drawing.Point(6, 17);
            this.dtp_trhsec.Name = "dtp_trhsec";
            this.dtp_trhsec.ShowUpDown = true;
            this.dtp_trhsec.Size = new System.Drawing.Size(238, 26);
            this.dtp_trhsec.TabIndex = 5;
            this.dtp_trhsec.Value = new System.DateTime(2022, 2, 13, 15, 39, 1, 0);
            this.dtp_trhsec.MouseLeave += new System.EventHandler(this.dtp_trhsec_MouseLeave);
            // 
            // dtp_zmnsec
            // 
            this.dtp_zmnsec.CalendarMonthBackground = System.Drawing.Color.Moccasin;
            this.dtp_zmnsec.CalendarTitleBackColor = System.Drawing.Color.SandyBrown;
            this.dtp_zmnsec.Checked = false;
            this.dtp_zmnsec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_zmnsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_zmnsec.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_zmnsec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_zmnsec.Location = new System.Drawing.Point(250, 17);
            this.dtp_zmnsec.Name = "dtp_zmnsec";
            this.dtp_zmnsec.ShowUpDown = true;
            this.dtp_zmnsec.Size = new System.Drawing.Size(91, 26);
            this.dtp_zmnsec.TabIndex = 6;
            this.dtp_zmnsec.MouseLeave += new System.EventHandler(this.dtp_zmnsec_MouseLeave);
            // 
            // lbl_dtp_zmn
            // 
            this.lbl_dtp_zmn.AutoSize = true;
            this.lbl_dtp_zmn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dtp_zmn.Location = new System.Drawing.Point(6, 70);
            this.lbl_dtp_zmn.Name = "lbl_dtp_zmn";
            this.lbl_dtp_zmn.Size = new System.Drawing.Size(74, 24);
            this.lbl_dtp_zmn.TabIndex = 8;
            this.lbl_dtp_zmn.Text = "Zaman";
            // 
            // lbl_dtp_trh
            // 
            this.lbl_dtp_trh.AutoSize = true;
            this.lbl_dtp_trh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dtp_trh.Location = new System.Drawing.Point(6, 46);
            this.lbl_dtp_trh.Name = "lbl_dtp_trh";
            this.lbl_dtp_trh.Size = new System.Drawing.Size(58, 24);
            this.lbl_dtp_trh.TabIndex = 7;
            this.lbl_dtp_trh.Text = "Tarih";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_zmn);
            this.groupBox1.Controls.Add(this.lbl_trh);
            this.groupBox1.Controls.Add(this.lbl_trhzmn);
            this.groupBox1.Location = new System.Drawing.Point(16, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Load İşlemleri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_dtp_zmn);
            this.groupBox2.Controls.Add(this.lbl_dtp_trh);
            this.groupBox2.Controls.Add(this.dtp_zmnsec);
            this.groupBox2.Controls.Add(this.dtp_trhsec);
            this.groupBox2.Location = new System.Drawing.Point(384, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 110);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mouse_enter İşlemleri";
            // 
            // tarih_zaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_anamenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "tarih_zaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tarih_zaman";
            this.Load += new System.EventHandler(this.tarih_zaman_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_anamenu;
        private System.Windows.Forms.Label lbl_trhzmn;
        private System.Windows.Forms.Timer trhzmn_tmr;
        private System.Windows.Forms.Label lbl_trh;
        private System.Windows.Forms.Label lbl_zmn;
        private System.Windows.Forms.DateTimePicker dtp_trhsec;
        private System.Windows.Forms.DateTimePicker dtp_zmnsec;
        private System.Windows.Forms.Label lbl_dtp_zmn;
        private System.Windows.Forms.Label lbl_dtp_trh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}