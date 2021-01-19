using System;
using System.Windows.Forms;

namespace bahisOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             *  Bu oyunda iki oyuncu vardır.
             *  Her oyuncunun bir zarı vardır.
             *  Oyuncular zar atar
             *  Zarlar karşılaştırılır.
             *  Büyük atan kazanır.
             *  
             *  Nesneler:
             *   - Oyun
             *   - Oyuncu
             *   - Zar
             *  
             */
        }

        Oyun zarOyunu = new Oyun();
        private void buttonAd1_Click(object sender, EventArgs e)
        {
            
            string oyuncuAdi = textBoxOyuncu1Ad.Text;
            zarOyunu.BirinciOyuncu = new Oyuncu(oyuncuAdi);
            zarOyunu.BirinciOyuncu.OyuncununZari = new Zar();
            labelOyuncu1Ad.Text = zarOyunu.BirinciOyuncu.Ad;
        }

        private void buttonAd2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncu = new Oyuncu(textBoxOyuncu2Ad.Text);
            zarOyunu.IkinciOyuncu.OyuncununZari = new Zar();
            labelOyuncu2Ad.Text = zarOyunu.IkinciOyuncu.Ad;
        }

        private void buttonOyuncu1_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuZarAt();
            labelOyuncu1Zar.Text = zarOyunu.BirinciOyuncu.OyuncununZari.Deger.ToString();
            buttonOyuncu2.Enabled = true;
        }

        private void buttonOyuncu2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncuZarAt();
            labelOyuncu2Zar.Text = zarOyunu.IkinciOyuncu.OyuncununZari.Deger.ToString();

            if (zarOyunu.BirinciOyuncu.Bakiye - zarOyunu.IkinciOyuncu.Bahis <= 0 || zarOyunu.IkinciOyuncu.Bakiye - zarOyunu.BirinciOyuncu.Bahis <= 0)
            {
                labelKazanan.Text = $"Oyun bitti ";
                return;
            }
            Oyuncu kazanan = zarOyunu.Karsilastir();
            //Bahis kazanilanPara;

            label7label6KalanBakiye1.Text = Convert.ToString(zarOyunu.BirinciOyuncu.Bakiye);
            label7label6KalanBakiye2.Text = Convert.ToString(zarOyunu.IkinciOyuncu.Bakiye);


            if (kazanan != null)
            {
               labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak bahisi kazandı ";

            }
            else
            {
                labelKazanan.Text = "Berabere!!!!";
            }

        }

        private void button1OyuncuBahis_Click(object sender, EventArgs e)
        {
            int oyuncuBahis = int.Parse(textBox1OyuncuBahisMiktari.Text);
            if (oyuncuBahis > 100) 
                {
                label2.Text = "0-100 arasında bahis giriniz."; 
                }
            zarOyunu.BirinciOyuncu = new Oyuncu(oyuncuBahis);
            zarOyunu.BirinciOyuncu.OyuncununZari = new Zar();
            labelOyuncu1Ad.Text = zarOyunu.BirinciOyuncu.Ad;
        }

        private void textBox1OyuncuBahisMiktari_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2OyuncuBahis_Click(object sender, EventArgs e)
        {
            int oyuncuBahis = int.Parse(textBox2OyuncuBahisMikatari.Text);
            if (oyuncuBahis > 100)
            {
                label3.Text = "0-100 arasında bahis giriniz.";
            }
            zarOyunu.IkinciOyuncu = new Oyuncu(oyuncuBahis);
            zarOyunu.IkinciOyuncu.OyuncununZari = new Zar();
            labelOyuncu1Ad.Text = zarOyunu.IkinciOyuncu.Ad;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2OyuncuBahisMikatari_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOyuncu1Ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOyuncu2Ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7label6KalanBakiye1_Click(object sender, EventArgs e)
        {

        }
    }
}
