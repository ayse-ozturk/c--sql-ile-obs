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
    public partial class ogrsınavlar : Form
    {
        public ogrsınavlar()
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
            SqlCommand command2 = new SqlCommand("select  sv.Ders_Kodu as [Ders Kodu],d.Ders_Adı as [Ders Adı],sv.Sınav_Adı [Sınav Adı], " +
                "sv.Etki_Oranı as [Etki Oranı],sv.Sınav_Tarihi as [sınav Tarihi] ," +
                "sv.Sınav_Notu as [Sınav Notu] , ISNULL(sv.Harf_Notu,'') as [Harf Notu]" +
                "from tbl_Sınavlar sv inner join tbl_Ders d on sv.Ders_Kodu=d.Ders_Kodu " +
                "where d.Bolum='" + Bolum + "' and  d.Yarıyıl='" + Yarıyıl + "' ", baglanti);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(command2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------

        private void ogrsınavlar_Load(object sender, EventArgs e)
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
