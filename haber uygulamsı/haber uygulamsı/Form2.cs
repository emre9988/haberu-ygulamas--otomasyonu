using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace haber_uygulamsı
{
    public partial class Form2 : Form
    {

        string DosyaYolu;
        int habersayi = 1;
        SqlConnection baglanti = new SqlConnection("Data Source=Emre-HP;Initial Catalog=haberuygulama;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        string verisay(string aranan)
        {
            
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



        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaresim = new OpenFileDialog();
            dosyaresim.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosyaresim.FilterIndex = 1;
            dosyaresim.ShowDialog();
            DosyaYolu = dosyaresim.FileName;
            pictureBox2.ImageLocation = DosyaYolu;
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
                
            string resimyolu = "haber\\" + (habersayi + 1).ToString() + ".jpg";
            string ekle;
            ekle = "insert into haber(haberid,haberbaslik,habericerik,haberresim) values(@hid,@hbaslik,@hicerik,@hresim)";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("@hid", label7.Text);
            komut.Parameters.AddWithValue("@hbaslik", textBox2.Text);
            komut.Parameters.AddWithValue("@hicerik", richTextBox2.Text);
            komut.Parameters.AddWithValue("@hresim", resimyolu);


            komut.ExecuteNonQuery();
            baglanti.Close();

            try
            {
                string dosyaadi = (habersayi + 1).ToString();
                string uygulamayolu = Application.StartupPath.ToString();

                string resimyolu2 = uygulamayolu + "\\haber/" + dosyaadi + ".jpg";
                pictureBox2.Image.Save(resimyolu2);
                pictureBox2.Image = null;
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox txt = item as TextBox;
                        txt.Clear();
                    }

                }
                foreach (Control item in this.Controls)
                {
                    if (item is RichTextBox)
                    {
                        RichTextBox richtxt = item as RichTextBox;
                        richtxt.Clear();
                    }

                }
                MessageBox.Show("Haberiniz başarıyla kaydedildi");
            }
            catch
            {
                MessageBox.Show("dosya yüklenirken hata çıktı lütfen tekrar deneyiniz");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(verisay("1"));   
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        { }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 forma1 = new Form1();
            forma1.Show();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            label7.Text = Convert.ToString(verisay("1"));
        }
    }
    }

