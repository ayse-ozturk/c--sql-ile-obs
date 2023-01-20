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
    public partial class dersler : Form
    {
        public dersler()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");

        //-----------------------------Fonksiyonlar---------------------------------------------------------------------------------------------
        //tbl_Sınavlar tablosundaki verileri düzenler
        public void sınavlarıDuzenle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_Sınavlar Set  Ders_Kodu = @Ders_Kodu where Ders_Kodu = @Ders_Kodu", baglanti);
            komut.Parameters.Add(new SqlParameter("@Ders_Kodu", SqlDbType.VarChar)).Value = textBox4.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        //tbl_Yoklama tablosundaki verileri düzenler
        public void YoklamaDuzenle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_Yoklama Set Ders_Kodu=@Ders_Kodu,Ders_Adı=@Ders_Adı,Yarıyıl=@Yarıyıl where Ders_Kodu = @Ders_Kodu", baglanti);
            komut.Parameters.Add(new SqlParameter("@Ders_Kodu", SqlDbType.VarChar)).Value = textBox4.Text;
            komut.Parameters.Add(new SqlParameter("@Yarıyıl", SqlDbType.VarChar)).Value = textBox3.Text;
            komut.Parameters.Add(new SqlParameter("@Ders_Adı", SqlDbType.VarChar)).Value = textBox5.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //formu tekrardan açarak tablodaki güncellmeleri görebilmek için
        public void yenile()
        {
            dersler f1 = new dersler();
            f1.Show();
            this.Hide();
        }
        //
        public void YoklamaEkle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" INSERT INTO tbl_Yoklama(Ders_Kodu,Ders_Adı,Yarıyıl,Ders_Yoklama_Durumu)" +
            " values(@Ders_Kodu,@Ders_Adı,@Yarıyıl,@Ders_Yoklama_Durumu)", baglanti);
            komut.Parameters.Add(new SqlParameter("@Ders_Kodu", SqlDbType.VarChar)).Value = textBox4.Text;
            komut.Parameters.Add(new SqlParameter("@Ders_Adı", SqlDbType.VarChar)).Value = textBox5.Text;
            komut.Parameters.Add(new SqlParameter("@Yarıyıl", SqlDbType.VarChar)).Value = textBox3.Text;
            komut.Parameters.Add(new SqlParameter("@Ders_Yoklama_Durumu", SqlDbType.VarChar)).Value = "";
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //form açıldıdğında tbl_Ders tablosunu dataGridView1 tablosunda gözükür      
        private void dersler_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Ders", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        //butona basıldığında up_spdersDuzenle Procedure çağırarak tablodaki değerler güncellenir
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("up_spdersDuzenle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add(new SqlParameter("@Fakulte", SqlDbType.NChar)).Value = textBox1.Text;
            komut.Parameters.Add(new SqlParameter("@Bolum", SqlDbType.Int.ToString())).Value = textBox2.Text;
            komut.Parameters.Add(new SqlParameter("@Yarıyıl", SqlDbType.NChar)).Value = textBox3.Text;
            komut.Parameters.Add(new SqlParameter("@Ders_Kodu", SqlDbType.NChar)).Value = textBox4.Text;
            komut.Parameters.Add(new SqlParameter("@Ders_Adı", SqlDbType.NChar)).Value = textBox5.Text;
            komut.Parameters.Add(new SqlParameter("@AKTS", SqlDbType.NChar)).Value = textBox6.Text;
            komut.Parameters.Add(new SqlParameter("@ÖğretimGörevlisi", SqlDbType.NChar)).Value = textBox7.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            YoklamaDuzenle();
            sınavlarıDuzenle();
        }
        //butona basıldığında up_spdersEkle Procedure çağırarak tablodaki değerler güncellenir
        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("up_spdersEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add(new SqlParameter("@Fakulte", SqlDbType.VarChar)).Value = textBox1.Text;
            komut.Parameters.Add(new SqlParameter("@Bolum", SqlDbType.Int.ToString())).Value = textBox2.Text;
            komut.Parameters.Add(new SqlParameter("@Yarıyıl", SqlDbType.VarChar)).Value = textBox3.Text;
            komut.Parameters.Add(new SqlParameter("@Ders_Kodu", SqlDbType.VarChar)).Value = textBox4.Text;
            komut.Parameters.Add(new SqlParameter("@Ders_Adı", SqlDbType.VarChar)).Value = textBox5.Text;
            komut.Parameters.Add(new SqlParameter("@AKTS", SqlDbType.VarChar)).Value = textBox6.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenile();
           // sınavlarıEkle();
            YoklamaEkle();
        }
        //butona basıldığında Procedure çağırarak siler
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("up_spderstSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.Add(new SqlParameter("@Ders_Kodu", SqlDbType.Int.ToString())).Value = textBox4.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            //tbl_Sınavlar tablosundan trigger ile siler
            //tbl_Yoklama tablosundan trigger ile siler
        }
        //textBox değerlerini temizlemek için
        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            baglanti.Close();
        }
        //dataGridView1'in sutüna çift tıklandığında o sutünun değerini textBoxlara yazar 
        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            baglanti.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            baglanti.Close();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //admin_giris tablosuna geri gitmek için
        private void button1_Click_1(object sender, EventArgs e)
        {
            admin_giris f = new admin_giris();
            f.Show();
            this.Hide();
        }
    }
}
