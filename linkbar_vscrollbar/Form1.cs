using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linkbar_vscrollbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = vScrollBar1.Value.ToString();

            if (vScrollBar1.Value <= 25)
            {
                this.BackColor = Color.Aquamarine;
            }
           else if (vScrollBar1.Value <= 50)
            {
                this.BackColor = Color.Green;
            }
           else if (vScrollBar1.Value <= 75)
            {
                this.BackColor = Color.Yellow;
            }
           else
            {
                this.BackColor = Color.Orange;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com.tr");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
        }
    }
}
