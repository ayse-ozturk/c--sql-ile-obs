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
//Öğretim Görevlilerini ve bilgilerin listeler
namespace ayse_OBS
{
    public partial class ogOzluk : Form
    {
        public ogOzluk()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        private void ogOzluk_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select og.Tc, og.ÖğretimGörevlisi , og.Cinsiyet,og.cep_no," +
                "og.Unvan,og.Fakulte, og.Bolum ,d.Ders_Adı from  tbl_ogretimGorevlisi og  " +
                "inner join  tbl_Ders d on  d.ÖğretimGörevlisi=og.ÖğretimGörevlisi", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_giris f = new admin_giris();
            f.Show();
            this.Hide();
        }
    }
}
