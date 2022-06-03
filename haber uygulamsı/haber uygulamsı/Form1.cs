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
using System.Data.Sql;
using System.Data.SqlClient;


namespace haber_uygulamsı
{
    public partial class Form1 : Form

    {
        string DosyaYolu;
        int habersayi = 0;
        SqlConnection baglanti = new SqlConnection("Data Source=Emre-HP;Initial Catalog=haberuygulama;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sonveri = Convert.ToInt32(verisay("a"));



            string ekle;
            ekle = "select * from haber where haberid=" + sonveri + "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(ekle, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                pictureBox2.ImageLocation = Application.StartupPath.ToString() + "\\" + oku["haberresim"].ToString();
                richTextBox1.Text = oku["habericerik"].ToString();
                label1.Text = oku["haberbaslik"].ToString();

            }
            baglanti.Close();





        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            int indisim = Convert.ToInt32(verisay("a"));


            string ekle;
            ekle = "select * from haber where haberid=" + indisim + "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(ekle, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                pictureBox2.ImageLocation = Application.StartupPath.ToString() + "\\" + oku["haberresim"].ToString();
                richTextBox1.Text = oku["habericerik"].ToString();
                label1.Text = oku["haberbaslik"].ToString();

            }
            baglanti.Close();


        }
        string verisay(string aranan)
        {
            habersayi = 0;
            string ekle;
            ekle = "select * from haber";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(ekle, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                habersayi += 1;
            }
            baglanti.Close();
            return habersayi.ToString();
        }


            private void button1_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            this.Hide();
            forma2.Show();

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            int indisim = Convert.ToInt32(verisay("a")) - 1;


            string ekle;
            ekle = "select * from haber where haberid=" + indisim + "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(ekle, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                pictureBox2.ImageLocation = Application.StartupPath.ToString() + "\\" + oku["haberresim"].ToString();
                richTextBox1.Text = oku["habericerik"].ToString();
                label1.Text = oku["haberbaslik"].ToString();

            }
            baglanti.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int indisim = Convert.ToInt32(verisay("a")) - 2;


            string ekle;
            ekle = "select * from haber where haberid=" + indisim + "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(ekle, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                pictureBox2.ImageLocation = Application.StartupPath.ToString() + "\\" + oku["haberresim"].ToString();
                richTextBox1.Text = oku["habericerik"].ToString();
                label1.Text = oku["haberbaslik"].ToString();

            }
            baglanti.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int indisim = Convert.ToInt32(verisay("a")) - 3;


            string ekle;
            ekle = "select * from haber where haberid=" + indisim + "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(ekle, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                pictureBox2.ImageLocation = Application.StartupPath.ToString() + "\\" + oku["haberresim"].ToString();
                richTextBox1.Text = oku["habericerik"].ToString();
                label1.Text = oku["haberbaslik"].ToString();

            }
            baglanti.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            int indisim = Convert.ToInt32(verisay("a")) - 4;


            string ekle;
            ekle = "select * from haber where haberid=" + indisim + "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(ekle, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                pictureBox2.ImageLocation = Application.StartupPath.ToString() + "\\" + oku["haberresim"].ToString();
                richTextBox1.Text = oku["habericerik"].ToString();
                label1.Text = oku["haberbaslik"].ToString();

            }
            baglanti.Close();
        }
    }
}

