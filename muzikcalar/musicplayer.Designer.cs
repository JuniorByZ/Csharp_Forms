namespace muzikcalar
{
    partial class musicplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musicplayer));
            this.lbl_player = new System.Windows.Forms.Label();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.grp_player = new System.Windows.Forms.GroupBox();
            this.btn_pre = new System.Windows.Forms.Button();
            this.lbx_musics_url = new System.Windows.Forms.ListBox();
            this.pbx_cd = new System.Windows.Forms.PictureBox();
            this.btn_nxt = new System.Windows.Forms.Button();
            this.lbx_musics = new System.Windows.Forms.ListBox();
            this.btn_ext = new System.Windows.Forms.Button();
            this.btn_ps = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_vmt = new System.Windows.Forms.Button();
            this.btn_vup = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_vdwn = new System.Windows.Forms.Button();
            this.ofd_url = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.grp_player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_cd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_player
            // 
            this.lbl_player.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_player.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_player.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_player.ForeColor = System.Drawing.Color.Gold;
            this.lbl_player.Location = new System.Drawing.Point(257, 30);
            this.lbl_player.Name = "lbl_player";
            this.lbl_player.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_player.Size = new System.Drawing.Size(77, 56);
            this.lbl_player.TabIndex = 1;
            this.lbl_player.Text = "My";
            this.lbl_player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(78, 30);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(173, 24);
            this.axWMP.TabIndex = 0;
            this.axWMP.Visible = false;
            // 
            // grp_player
            // 
            this.grp_player.Controls.Add(this.axWMP);
            this.grp_player.Controls.Add(this.lbx_musics_url);
            this.grp_player.Controls.Add(this.pbx_cd);
            this.grp_player.Controls.Add(this.lbl_player);
            this.grp_player.Controls.Add(this.lbx_musics);
            this.grp_player.Controls.Add(this.btn_ext);
            this.grp_player.Controls.Add(this.btn_ps);
            this.grp_player.Controls.Add(this.btn_start);
            this.grp_player.Controls.Add(this.btn_vmt);
            this.grp_player.Controls.Add(this.btn_vup);
            this.grp_player.Controls.Add(this.btn_add);
            this.grp_player.Controls.Add(this.btn_stop);
            this.grp_player.Controls.Add(this.btn_vdwn);
            this.grp_player.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_player.Location = new System.Drawing.Point(12, 15);
            this.grp_player.Name = "grp_player";
            this.grp_player.Size = new System.Drawing.Size(349, 239);
            this.grp_player.TabIndex = 2;
            this.grp_player.TabStop = false;
            this.grp_player.Text = "My Music Player";
            // 
            // btn_pre
            // 
            this.btn_pre.AccessibleDescription = "";
            this.btn_pre.AccessibleName = "";
            this.btn_pre.BackColor = System.Drawing.Color.Transparent;
            this.btn_pre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pre.BackgroundImage")));
            this.btn_pre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pre.Location = new System.Drawing.Point(125, 283);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(30, 30);
            this.btn_pre.TabIndex = 4;
            this.btn_pre.Tag = "";
            this.btn_pre.UseVisualStyleBackColor = false;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // lbx_musics_url
            // 
            this.lbx_musics_url.FormattingEnabled = true;
            this.lbx_musics_url.ItemHeight = 22;
            this.lbx_musics_url.Location = new System.Drawing.Point(78, 60);
            this.lbx_musics_url.Name = "lbx_musics_url";
            this.lbx_musics_url.Size = new System.Drawing.Size(173, 26);
            this.lbx_musics_url.TabIndex = 3;
            this.lbx_musics_url.Visible = false;
            // 
            // pbx_cd
            // 
            this.pbx_cd.Image = ((System.Drawing.Image)(resources.GetObject("pbx_cd.Image")));
            this.pbx_cd.Location = new System.Drawing.Point(14, 30);
            this.pbx_cd.Name = "pbx_cd";
            this.pbx_cd.Size = new System.Drawing.Size(58, 56);
            this.pbx_cd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_cd.TabIndex = 2;
            this.pbx_cd.TabStop = false;
            // 
            // btn_nxt
            // 
            this.btn_nxt.AccessibleDescription = "";
            this.btn_nxt.AccessibleName = "";
            this.btn_nxt.BackColor = System.Drawing.Color.Transparent;
            this.btn_nxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nxt.BackgroundImage")));
            this.btn_nxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nxt.Location = new System.Drawing.Point(189, 283);
            this.btn_nxt.Name = "btn_nxt";
            this.btn_nxt.Size = new System.Drawing.Size(30, 30);
            this.btn_nxt.TabIndex = 6;
            this.btn_nxt.Tag = "";
            this.btn_nxt.UseVisualStyleBackColor = false;
            this.btn_nxt.Click += new System.EventHandler(this.btn_nxt_Click);
            // 
            // lbx_musics
            // 
            this.lbx_musics.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbx_musics.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_musics.FormattingEnabled = true;
            this.lbx_musics.ItemHeight = 16;
            this.lbx_musics.Location = new System.Drawing.Point(14, 135);
            this.lbx_musics.Name = "lbx_musics";
            this.lbx_musics.Size = new System.Drawing.Size(320, 84);
            this.lbx_musics.Sorted = true;
            this.lbx_musics.TabIndex = 10;
            this.lbx_musics.SelectedIndexChanged += new System.EventHandler(this.lbx_musics_SelectedIndexChanged);
            // 
            // btn_ext
            // 
            this.btn_ext.AccessibleDescription = "";
            this.btn_ext.AccessibleName = "";
            this.btn_ext.BackColor = System.Drawing.Color.Transparent;
            this.btn_ext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ext.BackgroundImage")));
            this.btn_ext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ext.Location = new System.Drawing.Point(304, 99);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(30, 30);
            this.btn_ext.TabIndex = 9;
            this.btn_ext.Tag = "";
            this.btn_ext.UseVisualStyleBackColor = false;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // btn_ps
            // 
            this.btn_ps.AccessibleDescription = "";
            this.btn_ps.AccessibleName = "";
            this.btn_ps.BackColor = System.Drawing.Color.Transparent;
            this.btn_ps.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ps.BackgroundImage")));
            this.btn_ps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ps.Location = new System.Drawing.Point(86, 99);
            this.btn_ps.Name = "btn_ps";
            this.btn_ps.Size = new System.Drawing.Size(30, 30);
            this.btn_ps.TabIndex = 8;
            this.btn_ps.Tag = "";
            this.btn_ps.UseVisualStyleBackColor = false;
            this.btn_ps.Click += new System.EventHandler(this.btn_ps_Click);
            // 
            // btn_start
            // 
            this.btn_start.AccessibleDescription = "";
            this.btn_start.AccessibleName = "";
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_start.BackgroundImage")));
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.Location = new System.Drawing.Point(14, 99);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(30, 30);
            this.btn_start.TabIndex = 5;
            this.btn_start.Tag = "";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_vmt
            // 
            this.btn_vmt.AccessibleDescription = "";
            this.btn_vmt.AccessibleName = "";
            this.btn_vmt.BackColor = System.Drawing.Color.Transparent;
            this.btn_vmt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_vmt.BackgroundImage")));
            this.btn_vmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_vmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vmt.Location = new System.Drawing.Point(177, 99);
            this.btn_vmt.Name = "btn_vmt";
            this.btn_vmt.Size = new System.Drawing.Size(30, 30);
            this.btn_vmt.TabIndex = 13;
            this.btn_vmt.Tag = "";
            this.btn_vmt.UseVisualStyleBackColor = false;
            this.btn_vmt.Click += new System.EventHandler(this.btn_vmt_Click);
            // 
            // btn_vup
            // 
            this.btn_vup.AccessibleDescription = "";
            this.btn_vup.AccessibleName = "";
            this.btn_vup.BackColor = System.Drawing.Color.Transparent;
            this.btn_vup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_vup.BackgroundImage")));
            this.btn_vup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_vup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vup.Location = new System.Drawing.Point(213, 99);
            this.btn_vup.Name = "btn_vup";
            this.btn_vup.Size = new System.Drawing.Size(30, 30);
            this.btn_vup.TabIndex = 11;
            this.btn_vup.Tag = "";
            this.btn_vup.UseVisualStyleBackColor = false;
            this.btn_vup.Click += new System.EventHandler(this.btn_vup_Click);
            // 
            // btn_add
            // 
            this.btn_add.AccessibleDescription = "";
            this.btn_add.AccessibleName = "";
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Location = new System.Drawing.Point(262, 99);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(30, 30);
            this.btn_add.TabIndex = 3;
            this.btn_add.Tag = "";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.AccessibleDescription = "";
            this.btn_stop.AccessibleName = "";
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_stop.BackgroundImage")));
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.Location = new System.Drawing.Point(50, 99);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(30, 30);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.Tag = "";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_vdwn
            // 
            this.btn_vdwn.AccessibleDescription = "";
            this.btn_vdwn.AccessibleName = "";
            this.btn_vdwn.BackColor = System.Drawing.Color.Transparent;
            this.btn_vdwn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_vdwn.BackgroundImage")));
            this.btn_vdwn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_vdwn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vdwn.Location = new System.Drawing.Point(141, 99);
            this.btn_vdwn.Name = "btn_vdwn";
            this.btn_vdwn.Size = new System.Drawing.Size(30, 30);
            this.btn_vdwn.TabIndex = 12;
            this.btn_vdwn.Tag = "";
            this.btn_vdwn.UseVisualStyleBackColor = false;
            this.btn_vdwn.Click += new System.EventHandler(this.btn_vdwn_Click);
            // 
            // ofd_url
            // 
            this.ofd_url.FileName = "ofd_url";
            this.ofd_url.Multiselect = true;
            // 
            // musicplayer
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(379, 370);
            this.ControlBox = false;
            this.Controls.Add(this.grp_player);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.btn_nxt);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "musicplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3 Player";
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.grp_player.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_cd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Label lbl_player;
        private System.Windows.Forms.GroupBox grp_player;
        private System.Windows.Forms.PictureBox pbx_cd;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_ext;
        private System.Windows.Forms.ListBox lbx_musics;
        private System.Windows.Forms.OpenFileDialog ofd_url;
        private System.Windows.Forms.ListBox lbx_musics_url;
        private System.Windows.Forms.Button btn_ps;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_nxt;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_vmt;
        private System.Windows.Forms.Button btn_vdwn;
        private System.Windows.Forms.Button btn_vup;
    }
}

