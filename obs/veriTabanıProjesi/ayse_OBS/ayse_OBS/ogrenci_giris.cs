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

namespace ayse_OBS
{
    public partial class ogrenci_giris : Form
    {
        
        public ogrenci_giris()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        //formlar arası bilgi aktarımı için global olarak tanımlanmış değişken
        public string tc;
        public string yıl;
        public string bolum;
        private void button2_Click(object sender, EventArgs e)
        {
            giris form1 = new giris();
            form1.Show();
            this.Hide();
        }

        private void ogrenci_giris_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from tbl_ozlukBilgisi where Tc='" + tc + "' ", baglanti);
            
            baglanti.Open();
            SqlDataReader dr = command.ExecuteReader();
            ders ders1 = new ders();
            
            if (dr.Read())
            {
                yıl= dr["Yarıyıl"].ToString();//Yarıyıl bilgisini ders formuna taşımak için
                bolum = dr["Bolum"].ToString();//Yarıyıl bilgisini ders formuna taşımak için
                

                label1.Text = dr["ÖğrenciNumarasi"].ToString();
                label2.Text = dr["Ad"].ToString().Trim() + " " + dr["Soyad"].ToString();
            }
          
            baglanti.Close();
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("update tbl_giris set Sifre='" + textBox1.Text.ToString() + "' where Tc='"+tc+"'", baglanti);
                SqlDataReader oku = komut1.ExecuteReader();
                if (!oku.Read())
                {
                    MessageBox.Show("ŞİFRE DEĞİŞTİ");
                }

                baglanti.Close();
            }
            else
            {
                MessageBox.Show("GİRİLEN ŞİFRE AYNI DEĞİL");
            }
        }

        private void şifreDeğiştirmeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            label4.Text="YENİ ŞİFRE:";
            label5.Text = "YENİ ŞİFRE TEKRAR:";
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            richTextBox1.Visible = false;
            label3.Visible = false;
        }

        private void özlükBilgisiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ozluk f = new ozluk();
            f.tc = tc;//Tc bilgisini ozluk formuna taşımak için
            f.Show();
            this.Hide();
            this.Close();
        }

        private void dersAlmaListesiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dersBilgiSistemi f = new dersBilgiSistemi();
            f.tc = tc;//Tc bilgisini dersBilgiSistemi formuna taşımak için
            f.Bolumegore = bolum;
            f.Show();
            this.Hide();
            this.Close();


        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ders f = new ders();
            f.tc = tc;//Tc bilgisini ders formuna taşımak için
            f.yarıyıl = yıl;
            f.bolum = bolum;
            f.Show();
            this.Hide();
            this.Close();
        }

        private void sınavlarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ogrsınavlar f = new ogrsınavlar();
            f.tc = tc;//Tc bilgisini ogrsınavlar formuna taşımak için
            f.Bolum = bolum;
            f.Yarıyıl = yıl;
            f.Show();
            this.Hide();
            this.Close();
        }

        private void yoklamaBilgisiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ogryoklama f = new ogryoklama();
            f.tc = tc;//Tc bilgisini ogryoklama formuna taşımak için
            f.Bolum = bolum;
            f.Yarıyıl = yıl;
            f.Show();
            this.Hide();
            this.Close();
        }
        private void harçİşlemleriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from tbl_ozlukBilgisi where Öğretim='ÖRGÜN' and Tc='" + tc + "'", baglanti);
            ogrharc ogrharc = new ogrharc();
            baglanti.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("HARÇ İŞLEMİNİNİZ BULUNMAMAKTADIR");
            }
            else
            {
                ogrharc.tc = tc;
                ogrharc.Show();
                this.Hide();
                this.Close();
            }
            baglanti.Close();

            
        }
    }
}
