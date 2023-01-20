//ADMİN ÖZLÜK BİLGİSİ
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
    public partial class ogrenci : Form
    {
        public ogrenci()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        //-----------------------------Fonksiyonlar------------------------------------------------------------------------------------------------
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
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            baglanti.Close();
        }
                public void yenile()
        {
            ogrenci f1 = new ogrenci();
            f1.Show();
            this.Hide();
        }
        public void kayitDuzenle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" Update tbl_kayitOl Set Tc = @Tc,Ad = @Ad, Soyad = @Soyad where Tc = @Tc", baglanti);
            komut.Parameters.Add(new SqlParameter("@Tc", SqlDbType.Int.ToString())).Value = textBox1.Text;
            komut.Parameters.Add(new SqlParameter("@Ad", SqlDbType.NChar)).Value = textBox7.Text;
            komut.Parameters.Add(new SqlParameter("@Soyad", SqlDbType.NChar)).Value = textBox8.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------
        private void ogrenci_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_ozlukBilgisi", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("up_spozlukDuzenle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.Add(new SqlParameter("@Tc", SqlDbType.Int)).Value = textBox1.Text;
            komut.Parameters.Add(new SqlParameter("@Yetki", SqlDbType.NChar.ToString())).Value = textBox2.Text;
            komut.Parameters.Add(new SqlParameter("@ÖğrenciNumarasi", SqlDbType.Int)).Value = textBox3.Text;
            komut.Parameters.Add(new SqlParameter("@Fakulte", SqlDbType.NChar)).Value = textBox4.Text;
            komut.Parameters.Add(new SqlParameter("@Bolum", SqlDbType.NChar)).Value = textBox5.Text;
            komut.Parameters.Add(new SqlParameter("@Öğretim", SqlDbType.NChar)).Value = textBox6.Text;
            komut.Parameters.Add(new SqlParameter("@Ad", SqlDbType.NChar)).Value = textBox7.Text;
            komut.Parameters.Add(new SqlParameter("@Soyad", SqlDbType.NChar)).Value = textBox8.Text;
            komut.Parameters.Add(new SqlParameter("@BursBigisi", SqlDbType.NChar)).Value = textBox9.Text;
            komut.Parameters.Add(new SqlParameter("@Yarıyıl", SqlDbType.Int)).Value = textBox10.Text;
            komut.Parameters.Add(new SqlParameter("@GecişŞekli", SqlDbType.NChar)).Value = textBox11.Text;
            komut.Parameters.Add(new SqlParameter("@KayıtYılı", SqlDbType.NChar)).Value = textBox12.Text;
            komut.Parameters.Add(new SqlParameter("@Ortalama", SqlDbType.Float)).Value = textBox13.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            kayitDuzenle();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            admin_giris f = new admin_giris();
            f.Show();
            this.Hide();
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
            textBox9.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            textBox12.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            textBox13.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            baglanti.Close();
        }
    }
}
