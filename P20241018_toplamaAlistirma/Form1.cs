using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P20241018_toplamaAlistirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int s1_1, s1_2,s2_1,s2_2,s3_1,s3_2,sonuc1,sonuc2,sonuc3;

        private void button1_Click(object sender, EventArgs e)
        {
            lblT1_1.Text = rnd.Next(100, 999).ToString();
            lblT1_2.Text = rnd.Next(10, 99).ToString();
            lblT2_1.Text = rnd.Next(100, 999).ToString();
            lblT2_2.Text = rnd.Next(10, 99).ToString();
            lblT3_1.Text = rnd.Next(100, 999).ToString();
            lblT3_2.Text = rnd.Next(10, 99).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblT1_1.Text = rnd.Next(100,999).ToString();
            lblT1_2.Text = rnd.Next(10,99).ToString();
            lblT2_1.Text = rnd.Next(100,999).ToString();
            lblT2_2.Text = rnd.Next(10,99).ToString();
            lblT3_1.Text = rnd.Next(100,999).ToString();
            lblT3_2.Text = rnd.Next(10,99).ToString();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            int dsayisi = 0;
            s1_1 = Convert.ToInt32(lblT1_1.Text);
            s1_2= Convert.ToInt32(lblT1_2.Text);
            s2_1= Convert.ToInt32(lblT2_1.Text);
            s2_2= Convert.ToInt32(lblT2_2.Text);
            s3_1= Convert.ToInt32(lblT3_1.Text);
            s3_2= Convert.ToInt32(lblT3_2.Text);
            sonuc1 = s1_1 + s1_2;
            sonuc2 = s2_1 + s2_2;
            sonuc3 = s3_1 + s3_2;
            int cevap1 = Convert.ToInt32(txtSonuc1.Text);
            int cevap2 = Convert.ToInt32(txtSonuc2.Text);
            int cevap3 = Convert.ToInt32(txtSonuc3.Text);
            lblSonuc1.Text = (sonuc1==cevap1).ToString();
            lblSonuc2.Text = (sonuc2==cevap2).ToString();
            lblSonuc3.Text = (sonuc3==cevap3).ToString();
            if (Convert.ToBoolean(lblSonuc1.Text))
                dsayisi++;            
            if (Convert.ToBoolean(lblSonuc2.Text))
                dsayisi++;            
            if (Convert.ToBoolean(lblSonuc3.Text))
                dsayisi++;
            lblDogruSayisi.Text = "Toplam Doğru Sayısı:" + dsayisi;
        }
    }
}
