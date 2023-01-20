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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        //-----------------------------Fonksiyonlar------------------------------------------------------------------------------------------------
        //formda yaptığımız değişiklikleri görebilmemeiz için formu yenileyen fonksiyon
        public void yenile()
        {
            kayit f1 = new kayit();
            f1.Show();
            this.Hide();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //form açıldığında  tbl_kayitOl tablosundaki verileri dataGridView1 aktarmak için
        private void kayit_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from  tbl_kayitOl", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            
        }
        //butona basıldığında tecBoxları temizler
        private void button5_Click_1(object sender, EventArgs e)
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
            baglanti.Close();
        }
        //butona basıldığında SP çağırarak  tbl_kayitOl tablosundaki siler 
        //aynı zamanda tetikciler sayesinde aynı kişinin tbl_ozlukBilgisi ve tbl_giris tablosundaki verilerinide siler
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("up_spkayitSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.Add(new SqlParameter("@Tc", SqlDbType.Int.ToString())).Value = textBox2.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenile();
            //tbl_ozlukBilgisi tablosundan trigger ile siler
            //tbl_giris tablosundan trigger ile siler

        }
        //admin_giris formuna geri dönmek için
        private void button1_Click_1(object sender, EventArgs e)
        {
            admin_giris f = new admin_giris();
            f.Show();
            this.Hide();
        }
        //texBoxlara  dataGridView1 sutndaki bilgileri aktarmak için
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
            baglanti.Close();
        }
    }
}
