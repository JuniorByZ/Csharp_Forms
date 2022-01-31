using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pointkullanımveasansoruygulama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = "1";
            label4.BackColor = Color.White;
            label5.BackColor = Color.White;
            label6.BackColor = Color.White;
            label7.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = "0";
            label4.BackColor = Color.White;
            label5.BackColor = Color.White;
            label6.BackColor = Color.White;
            label7.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label9.Text == "1")
            {   
                label8.Top -= 5;
                if (label8.Top <= 102)
                {
                   timer1.Stop();
                    label6.BackColor = Color.Red;
                    label7.BackColor = Color.Red;
                }
            }

            if (label9.Text == "0")
            {
                label8.Top += 5;
                if (label8.Top >= 402)
                {
                    timer1.Stop();
                    label4.BackColor = Color.Red;
                    label5.BackColor = Color.Red;

                }
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
