namespace kayit_defteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            label4.Text = textBox2.Text;
            label9.Text = comboBox1.Text;
            label11.Text = textBox3.Text;
        }
    }
}