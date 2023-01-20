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
    public partial class dersBilgiSistemi : Form
    {
        public dersBilgiSistemi()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        //Formlar arasındaki veri geçişi için tanımlanmış global değişkenler
        public string Bolumegore;
        public string tc;

        //-----------------------------Fonksiyonlar---------------------------------------------------------------------------------------------
        //tbl_Ders tablosunda Bolumegore verisi eğer Bolum sutunundaki değerle eşleşiyor ise
        //o verilerle dataGridView1'i doldururan fonksiyon  
        public void datadoldurma()
        {
            SqlCommand command = new SqlCommand("select * from tbl_Ders where Bolum='" + Bolumegore + "' order by Yarıyıl" , baglanti);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------

        //Form açıldığında girişte girilen Tc değerine göre tbl_ozlukBilgisi tablosundaki verileri labellara yazar 
        private void dersBilgiSistemi_Load(object sender, EventArgs e)
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
        //ogrenci_giris formuna geri dönmek için
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
