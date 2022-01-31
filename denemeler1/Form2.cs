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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
            Random random = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int num1 = random.Next(1,101);
            int num2 = random.Next(1, 101);
            label1.Text = num1.ToString();
            label2.Text = num2.ToString();
        }
    }
}
