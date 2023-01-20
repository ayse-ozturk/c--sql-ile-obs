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
//Öğretim görevlisi öğrencilerinin notlandırmasını yapması için 
namespace ayse_OBS
{
    public partial class ogNotlandırma : Form
    {
        public ogNotlandırma()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        //formlar arası bilgi aktarımı için global olarak tanımlanmış değişken
        public string tc;
        public string ad;
        //-----------------------------Fonksiyonlar------------------------------------------------------------------------------------------------
        //dataGridView2 beliritlen değerlerle doldurmak için 
        public void doldur()
        {
            SqlCommand command = new SqlCommand("select s.Tc,d.Ders_Kodu as [Ders Kodu], " +
                "d.Ders_Adı as [Ders Adı] " +
                "from tbl_ozlukBilgisi s full join  tbl_Ders d on  " +
                "d.Fakulte=s.Fakulte where d.ÖğretimGörevlisi='" + ad + "'", baglanti);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
        }
        public void yenile()
        {
            ogNotlandırma og = new ogNotlandırma();
            og.ad = ad;
            og.Show();
            this.Close();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //form  açıldığında dataGridView1 belirtilen değerlerle doldurmak için
        private void ogNotlandırma_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select s.Tc, s.Ders_Kodu as [Ders Kodu],d.Ders_Adı as [Ders Adı]" +
            " ,s.Sınav_Adı as [Sınav Adı] , s.Etki_Oranı as [Etki Oranı] " +
            ",s.Sınav_Tarihi as [Sınav Tarihi],s.Sınav_Notu as [Sınav Notu]," +
            "s.Harf_Notu as [Harf Notu] " +
            "from tbl_Sınavlar s inner join  tbl_Ders d on d.Ders_Kodu=s.Ders_Kodu " +
            "where d.ÖğretimGörevlisi='" + ad + "'", baglanti);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            doldur();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
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
            textBox7.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            baglanti.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update tbl_Sınavlar Set Sınav_Adı=@k5," +
                "Etki_Oranı=@k1" +
                ",Sınav_Notu=@k2," +
                "Harf_Notu=@k3" +
                " where Ders_Kodu =@k4 and Tc=@k6", baglanti);
            baglanti.Open();
            command.Parameters.AddWithValue("@k6", textBox1.Text);
            command.Parameters.AddWithValue("@k5", textBox4.Text);
            command.Parameters.AddWithValue("@k1", textBox5.Text);
            command.Parameters.AddWithValue("@k2", textBox7.Text);
            command.Parameters.AddWithValue("@k3", textBox8.Text);
            command.Parameters.AddWithValue("@k4", textBox2.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            yenile();

        }

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
            textBox8.Text = "";
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ogretimGorevlisi_Giris f = new ogretimGorevlisi_Giris();
            f.Show();
            f.ad = ad;
            this.Close();
        }

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
            textBox8.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            baglanti.Close();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            baglanti.Open();
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("up_spSınavlarEkle", baglanti);
            baglanti.Open();
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add(new SqlParameter("@Tc", SqlDbType.Int.ToString())).Value = textBox1.Text;
            komut.Parameters.Add(new SqlParameter("@Ders_Kodu", SqlDbType.NChar)).Value = textBox2.Text;
            komut.Parameters.Add(new SqlParameter("@Sınav_Adı", SqlDbType.NChar)).Value = textBox4.Text;
            komut.Parameters.Add(new SqlParameter("@Etki_Oranı", SqlDbType.NChar)).Value = textBox5.Text;
            komut.Parameters.Add(new SqlParameter("@Sınav_Tarihi", SqlDbType.NChar)).Value = textBox6.Text;
            komut.Parameters.Add(new SqlParameter("@Sınav_Notu", SqlDbType.NChar)).Value = textBox7.Text;
            komut.Parameters.Add(new SqlParameter("@Harf_Notu", SqlDbType.NChar)).Value = textBox8.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenile();

        }
    }
}
