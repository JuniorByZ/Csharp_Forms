namespace ORTALAMA
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            vize = 0; final = 0;ortalama = 0;
            string ad, soyad, sonuc;
            ad = txt_ad.Text; soyad = txt_soyad.Text;
            vize = Convert.ToDouble(txt_vize.Text);
            final = Convert.ToDouble(txt_final.Text);
            ortalama = Convert.ToInt32((vize * 0.40) + (final * 0.60));
            txt_ortalama.Text = ortalama.ToString();
            if (ortalama > 60) {sonuc = "Geçti";}
            else {sonuc = "Kaldý";}
            txt_sonuc.Text = sonuc;
            lst_ogr_bilgi_ekran.Items.Add($"{ad}         {soyad}             {vize}              {final}                   {ortalama}                     {sonuc}");
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_vize.Clear();
            txt_final.Clear();
            txt_ortalama.Clear();
            txt_sonuc.Clear();
        }
    }
}
