using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dizi oluşturma
            string[] Gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            label1.Text = " ";
            foreach (string Gun in Gunler)
            {
                label1.Text += Gun+" ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayılar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            label2.Text = sayılar[5].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayılar = { 1, 2, 3, 4, 5 };
            int toplam = 0;
            for (int i = 0; i < sayılar.Length; i++)
            {
                toplam += sayılar [i];
            }
            label3.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double[] sayılar = { 3.15, 6.76, 7.45, 9.333, 12.346, 64.12, 34.43 };
            double toplam = 0;
            foreach (double sayı in sayılar)
            {
                toplam += sayı;
            }
            label4.Text = toplam.ToString();
        }
    }
}
