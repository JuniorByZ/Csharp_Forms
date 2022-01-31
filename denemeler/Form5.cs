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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            ana.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.201:80/";
        }

        /*
        Kral Pop -> http://46.20.3.201:80/
        Lokum Fm -> http://sunucu2.radyolarburada.com:9070
        Bodrum Fm -> http://88.255.140.50:88/broadwave.m3u?src=1&rate=1
        Kordon Fm -> http://allergo.serverroom.us:8147
        Pal Fm -> http://77.223.136.16:9920/
        Best Fm -> http://46.20.7.125:80
        Taksim Pop -> http://cast1.taksim.fm:8014
        Taksim Fm -> http://cast1.taksim.fm:8000
        Odtü Fm -> http://stream.radyoodtu.com.tr:8006
        jest Fm -> http://jestfm.radyolarburada.com:8070

          
         */
    }
}
