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
    public partial class tarih_zaman1 : Form
    {
        DateTime zaman;
        public tarih_zaman1()
        {
            InitializeComponent();
            zaman = DateTime.Now;
            lbl_tarih.Text = string.Format("{0}/{1}/{2} // {3}:{4}:{5}", 
                zaman.Day, zaman.Month, zaman.Year, zaman.Hour, zaman.Minute, zaman.Second);
        }
        private void btn_anamenu_Click(object sender, EventArgs e)
        {
            ana_form ana = new ana_form();
            ana.Show();
            this.Hide();
        }
        public void dtp_trhzmn_sec_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtp_trhzmn_sec.Value;
            zaman = dt;
            trh_sec_tm.Start();
        }
        private void trh_sec_tm_Tick(object sender, EventArgs e)
        {
            zaman = zaman.AddSeconds(1);
            lbl_tarih.Text = string.Format("{0}/{1}/{2} // {3}:{4}:{5}",
                zaman.Day, zaman.Month, zaman.Year, zaman.Hour, zaman.Minute, zaman.Second);
        }
    }
}
