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
    public partial class ozluk : Form
    {
        public ozluk()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        //formlar arası bilgi aktarımı için global olarak tanımlanmış değişken
        public string tc;
        private void ozluk_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from tbl_ozlukBilgisi where Tc='" + tc + "'", baglanti);
            baglanti.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                label13.Text = dr["Yetki"].ToString();
                label1.Text = dr["Ad"].ToString().Trim() + " " + dr["Soyad"].ToString();

                textBox1.Text = dr["Tc"].ToString();
                textBox2.Text = dr["Yetki"].ToString();
                textBox3.Text = dr["ÖğrenciNumarasi"].ToString();
                textBox4.Text = dr["Fakulte"].ToString();
                textBox5.Text = dr["Bolum"].ToString();
                textBox6.Text = dr["Öğretim"].ToString();
                textBox7.Text = dr["Ad"].ToString();
                textBox8.Text = dr["Soyad"].ToString();
                textBox9.Text = dr["BursBigisi"].ToString();
                textBox10.Text = dr["Yarıyıl"].ToString();
                textBox11.Text = dr["GecişŞekli"].ToString();
                textBox12.Text = dr["KayıtYılı"].ToString();
                textBox13.Text = dr["Ortalama"].ToString();
            }
            baglanti.Close();
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
