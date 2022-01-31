using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notlarım
{
    public partial class tarih_zaman : Form
    {
        public tarih_zaman()
        {
            InitializeComponent();
        }

        private void btn_anamenu_Click(object sender, EventArgs e)
        {
            ana_form ana = new ana_form();
            ana.Show();
            this.Hide();
        }

        private void tarih_zaman_Load(object sender, EventArgs e)
        {
            trhzmn_tmr.Start();
        }

        private void trhzmn_tmr_Tick(object sender, EventArgs e)
        {
            lbl_trhzmn.Text = DateTime.Now.ToString("F");
            lbl_trh.Text = DateTime.Now.ToLongDateString();
            lbl_zmn.Text = DateTime.Now.ToLongTimeString();
        }

        private void dtp_trhsec_MouseLeave(object sender, EventArgs e)
        {
            lbl_dtp_trh.Text = dtp_trhsec.Value.ToLongDateString();
        }

        private void dtp_zmnsec_MouseLeave(object sender, EventArgs e)
        {
            lbl_dtp_zmn.Text = dtp_zmnsec.Value.ToLongTimeString();
        }
    }
}
