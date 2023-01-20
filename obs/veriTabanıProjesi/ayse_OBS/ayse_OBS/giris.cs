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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        string selectedcmbox;//comboBox1 secimleri için global olarak tanımlanır
        
        //form açılırken tasarım için bazı label ve butonlar görünümü kapatılıor  
        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;
            sifUnut_button.Visible = false;
            katıtOl_button.Visible = false;
        }
        private void giris_button_Click(object sender, EventArgs e)
        {
            baglanti.Open();//SQL Server bağlantısı açılır 
            //Eğer textBox1 ve textBox2 ye girilen değerler tbl_giris tablosundaki Tc ve Sifre sutünlarındaki değerler ile eşleşiyor ise 
            SqlCommand komut = new SqlCommand("select * from tbl_giris where Tc='"+textBox1.Text+"' and Sifre='"+textBox2.Text+"' ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);//dt içini doldurmak için
            DataTable dt = new DataTable();//sanal tablo
            da.Fill(dt);
            if (dt.Rows.Count > 0)//sanal tablonun sutun sayısı sıfırdan büyük ise
            {
                if (selectedcmbox.ToString() == "ADMİN")//Eğer comboBox1 değeri ADMİN ise admin_giris formuna geçiş 
                {
                    admin_giris formAdmin = new admin_giris();
                    formAdmin.Show();
                    this.Hide();
                }
                //Eğer comboBox1 değeri ÖĞRETİM GÖREVLİSİ ise ogretimGorevlisi_Giris formuna geçiş 
                else if (selectedcmbox.ToString() == "ÖĞRETİM GÖREVLİSİ")
                {
                    ogretimGorevlisi_Giris oggiris = new ogretimGorevlisi_Giris();
                    oggiris.tc = textBox1.Text;//oggiris.Tc nesnesin değerini textBox1 değerine eşitleriz 
                    oggiris.Show();
                    this.Hide();
                }
                //Eğer comboBox1 değeri ÖĞRENCİ ise ogrenci_giris formuna geçiş 
                else if (selectedcmbox.ToString() == "ÖĞRENCİ")
                {
                    ogrenci_giris ogrencigiristc = new ogrenci_giris();    
                    ogrencigiristc.tc = textBox1.Text;//ogrencigiristc.Tc nesnesin değerini textBox1 değerine eşitleriz 
                    ogrencigiristc.Show();
                    this.Hide();
                }
            }
            //Değilse hata mesajı gelir 
            else
            {
                MessageBox.Show("HATALI GİRİŞ! TEKRAR DENEYİNİZ!");
            }
            baglanti.Close();//SQL Server bağlantısı kapatılır 
        }
        private void sifUnut_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label6.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button1.Visible = true;
        }
        //comboBox1 değerlerine göre formun tasarımını değiştirmek için
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedcmbox = comboBox1.SelectedItem.ToString();
            if (selectedcmbox.ToString() == "ADMİN")
            {
                sifUnut_button.Visible = false;//buton görünümlüğü kapalı
                katıtOl_button.Visible = false;
                pictureBox1.Image = Image.FromFile("..\\..\\Resources\\admin.png");//pictureBox1 imagini değiştir
                label6.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button1.Visible = false;
                pictureBox1.Visible = true;//buton görünümlüğü açık

                label1.Text = "KULLACI KODU:";

            }
            if (selectedcmbox.ToString() == "ÖĞRETİM GÖREVLİSİ")
            {
                sifUnut_button.Visible = false;
                katıtOl_button.Visible = false;
                pictureBox1.Image = Image.FromFile("..\\..\\Resources\\ogr.png");
                label6.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button1.Visible = false;
                pictureBox1.Visible = true;
                label1.Text = "TC:";
            }
            if (selectedcmbox.ToString() == "ÖĞRENCİ")
            {
                sifUnut_button.Visible = true;
                katıtOl_button.Visible = true;
                pictureBox1.Image = Image.FromFile("..\\..\\Resources\\og.png");
                label6.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button1.Visible = false;
                pictureBox1.Visible = true;
                label1.Text = "TC:";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //tasarım için olan bölüm
            pictureBox1.Visible = true;
            label6.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;

            baglanti.Open();//SQL Server bağlantısı açılır 
            //tbl_giris tablosundaki sifre sutünundaki değeri textBox4 değeri ile güncelleyen sql komutu
            SqlCommand komut = new SqlCommand("update tbl_giris set Sifre='" + textBox4.Text.ToString() +
                "'where Tc=" + textBox3.Text.ToString() + "", baglanti);
            //SqlDataReader,SqlCommand çalışınca sorgunun dönen değerlerini okumaya yarayan araç
            SqlDataReader oku = komut.ExecuteReader();//oku nesnesi ile birden fazla satırı sonuc olarak döndürür
                                                      //eğer okuduğu değerler yok ise Ekrana mesaj gelir
            if (!oku.Read())
            {
                MessageBox.Show("ŞİFRE DEĞİŞTİ");
            }
            baglanti.Close();//SQL Server bağlantısı kapatılır 
        }
        //kAyıtOlma forumuna geçiş
        private void katıtOl_button_Click_1(object sender, EventArgs e)
        {
            kayitOl f = new kayitOl(); 
            f.Show();
            this.Hide();
        }
    }
    
}
