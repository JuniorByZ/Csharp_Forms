using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muzikcalar
{
    public partial class musicplayer : Form
    {
        public musicplayer()
        {
            InitializeComponent();
        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ofd_url.ShowDialog();

            for (int i = 0; i < ofd_url.SafeFileNames.Length; i++)
            {
                lbx_musics.Items.Add(ofd_url.SafeFileNames[i].ToString());
                lbx_musics_url.Items.Add(ofd_url.FileNames[i].ToString());
            }
        }

        private void lbx_musics_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbx_musics_url.SelectedIndex = lbx_musics.SelectedIndex;
            axWMP.URL = lbx_musics_url.SelectedItem.ToString();
            axWMP.Ctlcontrols.play();
        }

        private void btn_ps_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.pause();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.stop();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.play();
        }

        private void btn_nxt_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.fastForward();
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.fastReverse();
        }

        private void btn_vup_Click(object sender, EventArgs e)
        {
            axWMP.settings.volume += 10;
            lbl_player.Text = axWMP.settings.volume.ToString();
        }

        private void btn_vdwn_Click(object sender, EventArgs e)
        {
            axWMP.settings.volume -= 10;
            lbl_player.Text = axWMP.settings.volume.ToString();
        }

        private void btn_vmt_Click(object sender, EventArgs e)
        {
            axWMP.settings.volume = 0;
        }

    }
}
