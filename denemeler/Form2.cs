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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            ana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\wamp\\www\\Csharp\\Csharp_Forms\\denemeler\\components\\wwe.mp3";

        }

        private void button4_Click(object sender, EventArgs e)
        {

            pictureBox1.ImageLocation = "C:\\wamp\\www\\Csharp\\Csharp_Forms\\denemeler\\components\\exit.png";
        }
    }
}
