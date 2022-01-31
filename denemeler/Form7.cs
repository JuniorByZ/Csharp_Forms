using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            ana.Show();
            this.Hide();
        }

        int sayı1, sayı2;

        private void topla_CheckedChanged(object sender, EventArgs e)
        {
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox1.Text);
            label1.Text = Convert.ToString(sayı1 + sayı2);
            sayı1 = 0; sayı2 = 0;
            textBox1.Clear(); textBox2.Clear();
        }
    }
}
