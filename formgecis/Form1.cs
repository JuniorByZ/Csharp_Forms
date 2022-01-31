namespace formgecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form2 ana_ekran = new Form2();
                ana_ekran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Giriþ !...");
            }
        }
    }
}