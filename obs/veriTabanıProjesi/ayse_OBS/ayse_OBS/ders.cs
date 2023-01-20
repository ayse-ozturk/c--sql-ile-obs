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
//Girişte girilen Tc bilgisine göre kişinin Dönem derslerini listelemek için
namespace ayse_OBS
{
    public partial class ders : Form
    {
        public ders()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
       
        //formlar arası veri geçişi için kullanıcak değişkenler tanımlanır
        public string yarıyıl;
        public string tc;
        public string bolum;
        //-----------------------------Fonksiyonlar---------------------------------------------------------------------------------------------
        //tbl_Ders tablosunda Yarıyıl sutünundaki öğrencini yaryıl bilgine göre dataGridView1 de listeleyen fonksiyon 
        public void datadoldurma()
        {
            SqlCommand command2 = new SqlCommand("select * from tbl_Ders where Yarıyıl='" + yarıyıl + "' and " +
                "Bolum='" + bolum + "'", baglanti);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(command2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------

        //form açılırken tbl_ozlukBilgisi tablosunda giriş de girilen Tc bilgisine göre Yetki,Ad ve Soyad bilgisi alınır ve yazdırılır  
        private void ders_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from tbl_ozlukBilgisi where Tc='" + tc + "'", baglanti);
            baglanti.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = dr["Yetki"].ToString();
                label2.Text = dr["Ad"].ToString().Trim() + " " + dr["Soyad"].ToString();
            }
            baglanti.Close();
            datadoldurma();//fonksiyon çağrılır
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //ogrenci_giris tablosuna geri dönmek için olan buton
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
