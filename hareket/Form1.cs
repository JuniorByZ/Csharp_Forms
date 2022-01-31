using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hareket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = ayıcık.Location.X;
            int y = ayıcık.Location.Y;
            if (e.KeyCode == Keys.Right && x < 915)
            {
                x += 5;
                ayıcık.Location = new Point(x,y);
            }

            if (e.KeyCode == Keys.Left && x > -6)
            {
                x -= 5;
                ayıcık.Location = new Point(x,y);
            }
            if (e.KeyCode == Keys.Up && y > -4)
            {
                y -= 5;
                ayıcık.Location = new Point(x,y);
            }

            if (e.KeyCode == Keys.Down && y < 641)
            {
                y += 5;
                ayıcık.Location = new Point(x,y);
            }





        }
    }
}
