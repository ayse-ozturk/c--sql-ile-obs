using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace ayse_OBS
{
    public partial class kayitOl : Form
    {
        public kayitOl()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        int ID = 0;
        //tbl_ozlukBilgisi tablosuna girilen verileri eklemek için olan fonksiyon
        public void ozlukEkle()
        {
            baglanti.Open();//SQL Server bağlantısı açılır 
            //up_spozlukekle adlı Procedure sql komutu 
            SqlCommand komut = new SqlCommand("up_spozlukekle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;//komut tipi Procedure
            //texBoxlardan ve comboBoxlardan alınan değerler tabloya parametre olarak eklenir 
            komut.Parameters.Add(new SqlParameter("@Tc", SqlDbType.Int.ToString())).Value = textBox1.Text;
            komut.Parameters.Add(new SqlParameter("@Yetki", SqlDbType.NChar)).Value ="ÖĞRENCİ";
            //ÖğrenciNumarasi değeri her eklenen öğrencide değer değişmesi için
            komut.Parameters.Add(new SqlParameter("@ÖğrenciNumarasi", SqlDbType.Int.ToString())).Value = 220707030+ID;
            komut.Parameters.Add(new SqlParameter("@Fakulte", SqlDbType.NChar)).Value = comboBox4.Text;
            komut.Parameters.Add(new SqlParameter("@Bolum", SqlDbType.NChar)).Value = textBox8.Text;
            komut.Parameters.Add(new SqlParameter("@Öğretim", SqlDbType.NChar)).Value =comboBox6.Text;
            komut.Parameters.Add(new SqlParameter("@Ad", SqlDbType.NChar)).Value = textBox2.Text;
            komut.Parameters.Add(new SqlParameter("@Soyad", SqlDbType.NChar)).Value = textBox3.Text;
            komut.Parameters.Add(new SqlParameter("@BursBigisi", SqlDbType.NChar)).Value = comboBox7.Text;
            komut.Parameters.Add(new SqlParameter("@Yarıyıl", SqlDbType.Int.ToString())).Value = 1;
            komut.Parameters.Add(new SqlParameter("@GecişŞekli", SqlDbType.NChar)).Value ="ÖSS";
            komut.Parameters.Add(new SqlParameter("@KayıtYılı", SqlDbType.NChar.ToString())).Value ="2022";
            komut.Parameters.Add(new SqlParameter("@Ortalama", SqlDbType.Float.ToString())).Value =0;
            komut.ExecuteNonQuery();//yapılan işlmleri SQL de görmek için
            baglanti.Close();//SQL Server bağlantısı kapatılır 
        }
        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();//SQL Server bağlantısı açılır
            //up_spozlukekle adlı Procedure sql komutu 
            SqlCommand komut = new SqlCommand("up_spkayitOl", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            //texBoxlardan ve comboBoxlardan alınan değerler tabloya parametre olarak eklenir
            komut.Parameters.Add(new SqlParameter("@Uyruk", SqlDbType.VarChar)).Value = comboBox1.Text;
            komut.Parameters.Add(new SqlParameter("@Tc", SqlDbType.Int.ToString())).Value = textBox1.Text;
            komut.Parameters.Add(new SqlParameter("@Ad", SqlDbType.VarChar)).Value = textBox2.Text;
            komut.Parameters.Add(new SqlParameter("@Soyad", SqlDbType.VarChar)).Value = textBox3.Text;
            komut.Parameters.Add(new SqlParameter("@Anne_ad", SqlDbType.VarChar)).Value = textBox4.Text;
            komut.Parameters.Add(new SqlParameter("@Baba_ad", SqlDbType.VarChar)).Value = textBox5.Text;
            komut.Parameters.Add(new SqlParameter("@Dogum_tarihi", SqlDbType.DateTime.ToString())).Value = dateTimePicker2.Value.ToString("yyyyMMdd");
            komut.Parameters.Add(new SqlParameter("@cinsiyet", SqlDbType.VarChar)).Value = comboBox2.Text;
            komut.Parameters.Add(new SqlParameter("@cep_no", SqlDbType.Int.ToString())).Value = textBox6.Text;
            komut.Parameters.Add(new SqlParameter("@sehir", SqlDbType.VarChar)).Value = comboBox3.Text;
            komut.Parameters.Add(new SqlParameter("@sifre", SqlDbType.Int.ToString())).Value = textBox7.Text;
            komut.ExecuteNonQuery();//yapılan işlmleri SQL de görmek için
            baglanti.Close();//SQL Server bağlantısı kapatılır 
            ekle();//fonksiyonu çağrılır
            ozlukEkle();//fonksiyonu çağrılır
            MessageBox.Show("KAYITINIZ YAPILMIŞTIR.");//Ekrana mesaj gelir
            ID++;//artırılır
           
            //form1 geri dönmek için
            giris f = new giris();
            f.Show();
            this.Close();

        }
        //tbl_giris tablosuna girilen verilerin eklenmesi için olan fonksiyon
        private void ekle()
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("up_spgirisEkle", baglanti);
            komut3.CommandType = CommandType.StoredProcedure;
            komut3.Parameters.Add(new SqlParameter("@Tc", SqlDbType.Int.ToString())).Value = textBox1.Text;
            komut3.Parameters.Add(new SqlParameter("@Sifre", SqlDbType.Int.ToString())).Value = textBox7.Text;
            komut3.Parameters.Add(new SqlParameter("@Ad", SqlDbType.NChar)).Value = textBox2.Text;
            komut3.Parameters.Add(new SqlParameter("@Soyad", SqlDbType.NChar)).Value = textBox3.Text;
            komut3.Parameters.Add(new SqlParameter("@Yetki", SqlDbType.NChar)).Value = "ÖĞRENCİ";
            komut3.ExecuteNonQuery();
            baglanti.Close();
        }
        //form1 geri dönmek için
        private void button2_Click(object sender, EventArgs e)
        {
            giris f = new giris();
            f.Show();
            this.Close();
        }
    }
}
