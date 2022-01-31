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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            ana.Show();
            this.Hide();
        }
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label4.Text =Convert.ToString(a);
            label5.Text =Convert.ToString(b);
            label6.Text =Convert.ToString(c);
            label7.Text =Convert.ToString(d);
        }
    }
}
