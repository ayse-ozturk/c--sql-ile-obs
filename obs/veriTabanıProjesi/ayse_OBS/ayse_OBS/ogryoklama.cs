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
    public partial class ogryoklama : Form
    {
        public ogryoklama()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        //formlar arası bilgi aktarımı için global olarak tanımlanmış değişken
        public string Bolum;
        public string Yarıyıl;
        public string tc;
        //-----------------------------Fonksiyonlar------------------------------------------------------------------------------------------------
        public void datadoldurma()
        {
            SqlCommand command2 = new SqlCommand("select Ders_Kodu as [Ders Kodu] ,Ders_Adı as [Ders Adı] ," +
                "Yarıyıl,Ders_Yoklama_Durumu as [Ders Devam Yüzdesi]from tbl_Yoklama where Yarıyıl='" + Yarıyıl + "' and Tc='" + tc + "'  ", baglanti);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(command2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------
        private void ogryoklama_Load(object sender, EventArgs e)
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
            datadoldurma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci_giris f = new ogrenci_giris();
            f.tc = tc;
            f.Show();
            this.Hide();
            this.Close();
        }
    }
}
