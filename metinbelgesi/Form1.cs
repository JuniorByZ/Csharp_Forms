using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace metinbelgesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StreamWriter sw;
        string belgeadi, belgeyolu;

        private void button2_Click(object sender, EventArgs e)
        {
            belgeadi = textBox1.Text;
            sw = File.CreateText(belgeyolu + "\\" + belgeadi + ".txt");
            sw.Close();
            MessageBox.Show("Belge Oluşturuldu !...");

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satır = oku.ReadLine();
                while (satır != null)
                {
                    listBox1.Items.Add(satır);
                    satır = oku.ReadLine();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.Filter = "Metin Dosyası(*.txt) | *.txt";
            ac.Multiselect = false;
            if (ac.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = ac.SafeFileName;
                try
                {
                    StreamReader oku = new StreamReader(ac.FileName);
                    richTextBox1.Text = oku.ReadToEnd();
                    oku.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Dosya Okuma Hatası !...");
                }





            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Kayıt yeri Seçiniz !...";
                saveFileDialog1.Filter = "Metin Dosyası(*.txt) | *.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.InitialDirectory = "c:\\";
                saveFileDialog1.ShowDialog();
                StreamWriter kaydet=new StreamWriter(saveFileDialog1.FileName);
                kaydet.WriteLine(richTextBox2.Text);
                kaydet.Close();
                MessageBox.Show("Belge Yazdırıldı !...");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Dosya Yazma Hatası !...");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                belgeyolu= folderBrowserDialog1.SelectedPath.ToString();
                textBox2.Text = belgeyolu.ToString();

            }
        }
    }
}
