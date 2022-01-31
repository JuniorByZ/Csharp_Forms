namespace renklerin_dili
{
    public partial class ana_ekran : Form
    {
        public ana_ekran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeni = new();
            yeni.Show();
            this.Close();
        }
    }
}