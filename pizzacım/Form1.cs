namespace pizzacım
{
    public partial class Form1 : Form
    {
        public void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text); 
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox1.Text);
            string hbi = "";
            if (checkBox1.Checked)
                hbi = hbi + checkBox1.Text + " ";
            if (checkBox2.Checked)
                hbi = hbi + checkBox2.Text + " ";
            if (checkBox3.Checked)
                hbi = hbi + checkBox3.Text + " ";
            if (checkBox4.Checked)
                hbi = hbi + checkBox4.Text + " ";
            if (checkBox5.Checked)
                hbi = hbi + checkBox5.Text + " ";
            if (checkBox6.Checked)
                hbi = hbi + checkBox6.Text + " ";
            listBox6.Items.Add(hbi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}