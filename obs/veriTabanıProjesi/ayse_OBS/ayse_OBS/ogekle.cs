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

namespace ayse_OBS
{
    public partial class ogekle : Form
    {
        public ogekle()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        string[] adSoyad;
        //-----------------------------Fonksiyonlar------------------------------------------------------------------------------------------------
        //tbl_giris tablosundaki verileri düzenlemek için
        public void Duzenle()
        {
            adSoyad = textBox2.Text.Split(' ');//textBox2 deki veriyi boşluğa göre bölerek adSoyad dizinine atar 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_giris Set Tc=@Tc ,sifre=@sifre,Ad=@Ad ,Soyad=@Soyad where Tc=@Tc", baglanti);
            komut.Parameters.Add(new SqlParameter("@Tc", SqlDbType.Int.ToString())).Value = textBox1.Text;
            komut.Parameters.Add(new SqlParameter("@sifre", SqlDbType.Int.ToString())).Value = textBox8.Text;
            komut.Parameters.Add(new SqlParameter("@Ad", SqlDbType.Int.ToString())).Value = adSoyad[0];
            komut.Parameters.Add(new SqlParameter("@Soyad", SqlDbType.Int.ToString())).Value = adSoyad[1];
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //formda yaptığımız değişiklikleri görebilmemeiz için formu yenileyen fonksiyon
        public void yenile()
        {
            ogekle f1 = new ogekle();
            f1.Show();
            this.Hide();
        }
        // up_spgirisEkle adlı sp çağrırarak tbl_giris tablosuna veri ekler
        private void ekle()
        {
            adSoyad = textBox2.Text.Split(' ');
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("up_spgirisEkle", baglanti);
            komut3.CommandType = CommandType.StoredProcedure;

            komut3.Parameters.Add(new SqlParameter("@Tc", SqlDbType.Int.ToString())).Value = textBox1.Text;
            komut3.Parameters.Add(new SqlParameter("@Sifre", SqlDbType.Int.ToString())).Value = textBox8.Text;
            komut3.Parameters.Add(new SqlParameter("@Ad", SqlDbType.NChar)).Value = adSoyad[0];
            komut3.Parameters.Add(new SqlParameter("@Soyad", SqlDbType.NChar)).Value = adSoyad[1];
            komut3.Parameters.Add(new SqlParameter("@Yetki", SqlDbType.NChar)).Value = "ÖĞRETİM GÖREVLİSİ";
            komut3.ExecuteNonQuery();
            baglanti.Close();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //butona basıldığında adlı up_spOgretimDuzenle sp çağırarak tbl_ÖğretimGörevlisi tablosunu düzenler
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("up_spOgretimDuzenle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
           
            komut.Parameters.Add(new SqlParameter("@Tc", SqlDbType.Int.ToString())).Value = textBox1.Text;
            komut.Parameters.Add(new SqlParameter("@ÖğretimGörevlisi", SqlDbType.VarChar)).Value = textBox2.Text;
            komut.Parameters.Add(new SqlParameter("@Cinsiyet", SqlDbType.VarChar)).Value = comboBox1.Text;
            komut.Parameters.Add(new SqlParameter("@cep_no", SqlDbType.Int.ToString())).Value = textBox4.Text;
            komut.Parameters.Add(new SqlParameter("@Unvan", SqlDbType.VarChar)).Value = textBox5.Text.ToString();
            komut.Parameters.Add(new SqlParameter("@Fakulte", SqlDbType.VarChar)).Value = textBox6.Text;
            komut.Parameters.Add(new SqlParameter("@Bolum", SqlDbType.VarChar)).Value = textBox7.Text;
            komut.Parameters.Add(new SqlParameter("@sifre", SqlDbType.Int)).Value = textBox8.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            Duzenle();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.Text = "";

            baglanti.Close();
        }
        //butona basıldığında bir öğretim görevlisini siler
        //tetikliyici ile aynı kişi giriş tablosundan silinir
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("up_spogretimSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add(new SqlParameter("@Tc", SqlDbType.Int.ToString())).Value = textBox1.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            //tbl_giris tablosundan trigger ile siler
        }
        //form açıldığında tbl_ogretimGorevlisi tablosu dataGridView1yansıtıllır
        private void ogekle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_ogretimGorevlisi", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("up_spOgretimEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add(new SqlParameter("@Tc", SqlDbType.Int.ToString())).Value = textBox1.Text.ToString();
            komut.Parameters.Add(new SqlParameter("@ÖğretimGörevlisi", SqlDbType.VarChar)).Value = textBox2.Text;
            komut.Parameters.Add(new SqlParameter("@Cinsiyet", SqlDbType.VarChar)).Value = comboBox1.Text;
            komut.Parameters.Add(new SqlParameter("@cep_no", SqlDbType.Int.ToString())).Value = textBox4.Text;
            komut.Parameters.Add(new SqlParameter("@Unvan", SqlDbType.VarChar)).Value = textBox5.Text;
            komut.Parameters.Add(new SqlParameter("@Fakulte", SqlDbType.VarChar)).Value = textBox6.Text;
            komut.Parameters.Add(new SqlParameter("@Bolum", SqlDbType.VarChar)).Value = textBox7.Text;
            komut.Parameters.Add(new SqlParameter("@sifre", SqlDbType.Int)).Value = textBox8.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            ekle();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            baglanti.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_giris f = new admin_giris();
            f.Show();
            this.Hide();
        }
    }

}
