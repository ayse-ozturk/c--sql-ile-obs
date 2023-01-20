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
//Öğretim Görevlilerinine ders atamak için kullanılan form
namespace ayse_OBS
{
    public partial class dersAtama : Form
    {
        public dersAtama()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");

        //-----------------------------Fonksiyonlar---------------------------------------------------------------------------------------------
        //tbl_ogretimGorevlisi tablosunu dataGridView2 doldurmak için kullanılır 
        public void load()
        {
            SqlDataAdapter da = new SqlDataAdapter("select ÖğretimGörevlisi,Fakulte,Bolum from tbl_ogretimGorevlisi order by Fakulte", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
        }
        //tbl_Ders tablosundaki değerleri düzenlemek için olan fonksiyon
        public void duzenle()
        {
            SqlCommand komut = new SqlCommand("Update tbl_Ders Set ÖğretimGörevlisi ='" + textBox6.Text + "' where Ders_Kodu='" + textBox4.Text + "' ", baglanti);
            baglanti.Open();
            komut.Parameters.Add(new SqlParameter("@ÖğretimGörevlisi", SqlDbType.NChar)).Value = textBox6.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //formu tekrardan açarak tablodaki güncellmeleri görebilmek için
        public void yenile()
        {
            dersAtama f1 = new dersAtama();
            f1.Show();
            this.Hide();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------

        //tbl_Ders tablosounda verileri dataGridView1 tablosuna ekler
        private void dersAtama_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Ders order by Fakulte ", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            load();
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
            textBox6.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            baglanti.Close();
        }

        //Butona basıldığında tbl_Ders tablosundaki değerler güncellenir
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Update tbl_Ders Set ÖğretimGörevlisi = '" + textBox6.Text + "' " +
                " where Ders_Kodu='" + textBox4.Text + "'", baglanti);
            baglanti.Open();
            //komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add(new SqlParameter("@ÖğretimGörevlisi", SqlDbType.NChar)).Value = textBox6.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            duzenle();
            yenile();
        }

        //dataGridView2'in sutüna çift tıklandığında o sutünun değerini textBoxlara yazar 
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            baglanti.Open();
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox6.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            baglanti.Close();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //admin_giris formuna geri döner 
        private void button2_Click(object sender, EventArgs e)
        {
            admin_giris f = new admin_giris();
            f.Show();
            this.Hide();
        }
    }
}
