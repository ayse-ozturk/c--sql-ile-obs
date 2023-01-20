using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ayse_OBS
{
    public partial class sifbilgi : Form
    {
        public sifbilgi()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        //Form açıldığında tbl_kayitOl tablosundan belirtilmiş olan sutunları dataGridView1 de göstermek için
        private void sifbilgi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Tc,Ad,Soyad,Sifre from tbl_giris", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
           
        }
        //admin formuna dönmek için
        private void button1_Click_1(object sender, EventArgs e)
        {
            admin_giris f = new admin_giris();
            f.Show();
            this.Hide();
        }
    }
}
