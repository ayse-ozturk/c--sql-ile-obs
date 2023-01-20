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
    public partial class ogretimGorevlisi_Giris : Form
    {
        public ogretimGorevlisi_Giris()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        //formlar arası bilgi aktarımı için global olarak tanımlanmış değişken
        internal string tc;
        internal string ad;
        private void dERSİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            textBox9.Visible = false;
            textBox3.Visible = false;
            textBox10.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;

            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;

            SqlCommand command = new SqlCommand("select oz.ÖğrenciNumarasi ,oz.Ad,oz.Soyad, oz.Yarıyıl,d.Ders_Kodu " +
                ",d.Ders_Adı from tbl_Ders d inner join tbl_ozlukBilgisi  oz  on d.Bolum=oz.Bolum  " +
                "where d.ÖğretimGörevlisi='"+ ad +"'  order by d.Ders_Adı ", baglanti);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void nOTLANDIRMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogNotlandırma og = new ogNotlandırma();
            og.ad = ad;
            og.Show();
            this.Close();
        }

        private void ogretimGorevlisi_Giris_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

            textBox9.Visible = true;
            textBox3.Visible = true;
            textBox10.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;

            SqlCommand command = new SqlCommand("select * from tbl_ogretimGorevlisi where Tc='" + tc + "'", baglanti);
            baglanti.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                ad = dr["ÖğretimGörevlisi"].ToString();//Yarıyıl bilgisini ders formuna taşımak için


                label4.Text = " " + dr["ÖğretimGörevlisi"].ToString();

                textBox9.Text = dr["Tc"].ToString();
                textBox3.Text = dr["ÖğretimGörevlisi"].ToString();
                textBox10.Text = dr["Cinsiyet"].ToString();
                textBox5.Text = dr["Unvan"].ToString();
                textBox6.Text = dr["Fakulte"].ToString();
                textBox7.Text = dr["Bolum"].ToString();
            }
            baglanti.Close();



            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris form1 = new giris();
            form1.Show();
            this.Hide();
            this.Close();
        }

        private void yOKLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            textBox9.Visible = false;
            textBox3.Visible = false;
            textBox10.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;


            button2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            SqlCommand command = new SqlCommand("select Tc,Ders_Kodu as [Ders Kodu] ,Ders_Adı as [Ders Adı] ," +
    "Yarıyıl,Ders_Yoklama_Durumu as [Ders Devam Yüzdesi] ,ÖğretimGörevlisi as [Öğretim Görevlisi] from tbl_Yoklama" +
    " where ÖğretimGörevlisi='" + ad + "'   order by Tc", baglanti);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update tbl_Yoklama set Ders_Yoklama_Durumu=@Ders_Yoklama_Durumu where Tc='"+textBox1.Text+"'", baglanti);
            baglanti.Open();
            command.Parameters.Add(new SqlParameter("@Ders_Yoklama_Durumu", SqlDbType.NChar.ToString())).Value = textBox2.Text;
            command.ExecuteNonQuery();
            baglanti.Close();
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            baglanti.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            baglanti.Close();
        }
    }
}
