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
    public partial class ogrharc : Form
    {
        public ogrharc()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        //formlar arası bilgi aktarımı için global olarak tanımlanmış değişken
        public string tc;
        public void doldurma()
        {
            SqlCommand command = new SqlCommand("select * from tbl_ozlukBilgisi where Tc='" + tc + "' ", baglanti);

            baglanti.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = dr["ÖğrenciNumarasi"].ToString();
                label2.Text = dr["Ad"].ToString().Trim() + " " + dr["Soyad"].ToString();
            }
            baglanti.Close();
        }
        private void ogrharc_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("select ozbil.Ad, ozbil.Soyad, h.Harç as [Dönemlik Harç Bilgisi] " +
            "from tbl_ozlukBilgisi ozbil inner " +
            "join tbl_harc h on " +
            "ozbil.Tc = h.Tc where h.Tc='" + tc + "'", baglanti);
            baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            
            baglanti.Close();
            doldurma();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci_giris f = new ogrenci_giris();
            f.tc = tc;
            this.Hide();
            f.Show();
            this.Close();
        }
    }
}
