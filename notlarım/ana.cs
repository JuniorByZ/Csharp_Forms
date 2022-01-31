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
    public partial class ana_form : Form
    {
        public ana_form()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_trhzmn_Click(object sender, EventArgs e)
        {
            tarih_zaman trhzmn= new tarih_zaman();
            trhzmn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarih_zaman1 trhzmn1 = new tarih_zaman1();
            trhzmn1.Show();
            this.Hide();
        }
    }
}
