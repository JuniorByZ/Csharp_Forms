﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeler
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            ana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı;
            int saat, dakika;
            sayı = Convert.ToInt32(textBox1.Text);

            saat = sayı / 60;
            label1.Text = saat.ToString();

            dakika = sayı % 60;
            label2.Text = dakika.ToString();

        }
    }
}
