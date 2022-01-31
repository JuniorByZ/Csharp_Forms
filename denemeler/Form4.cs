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
    public partial class Form4 : Form
    {
        public Form4()
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
            for (int i = 1; i < 6; i++)
            {
                listBox1.Items.Add(i.ToString());   
            }

        }
        int i = 0;
        private void button3_Click(object sender, EventArgs e)
        {
           i++;
           listBox1.Items.Add(i);
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int faktoryel = 1;
            for (int i = 1; i < 6; i++)
            {
                faktoryel *= i;
                listBox1.Items.Add(faktoryel);
            }
        }
    }
}
