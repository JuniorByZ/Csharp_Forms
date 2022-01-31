using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_in_sharp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                otomobil oto = new otomobil();
                oto.marka = "Hyundai";
                oto.model = "Accent";
                oto.modelyil = 2021;
                oto.renk = "Yeşil";
                oto.vitestip = "Manuel";

                string marka = oto.markagetir();
                label10.Text = oto.marka.ToString();
                label9.Text = oto.model.ToString();
                label8.Text = oto.modelyil.ToString();
                label7.Text = oto.renk.ToString();
                label6.Text = oto.vitestip.ToString();

     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
