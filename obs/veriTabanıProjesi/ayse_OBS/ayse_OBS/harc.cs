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
    public partial class harc : Form
    {
        public harc()
        {
            InitializeComponent();
        }
        //SQL Server vertitabanına bağlanmak içi 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7BE1EJ0;Initial Catalog=obs;Integrated Security=True");
        //Formlar arasındaki veri geçişi için tanımlanmış global değişkenler
        internal string tc;
        //-----------------------------Fonksiyonlar---------------------------------------------------------------------------------------------
        //formu tekrardan açarak tablodaki güncellmeleri görebilmek için
        public void yenile()
        {
            harc f1 = new harc();
            f1.Show();
            this.Hide();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //form açıldığında tbl_ozlukBilgisi ve tbl_harc tablolarındaki belirtilen sutündaki değerleri
        //dataGridView1 tablosunda gösterir 
        private void harc_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select ob.Tc , ob.Öğretim, h.Harç from tbl_ozlukBilgisi ob inner join tbl_harc h on ob.Tc=h.Tc  ", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        //butona basıldığında up_upharcDuzenle Procedure çağrılır ve tbl_Harc tablosunda değerler düzenlenir
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("up_upharcDuzenle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add(new SqlParameter("@Harç", SqlDbType.Int.ToString())).Value = textBox2.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenile();

        }
        //textBox da yazanları temizlemek için
        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            textBox1.Text = "";
            textBox2.Text = "";
            baglanti.Close();
        }
        //admin_giris tablosuna geri gitmek için
        private void button1_Click_1(object sender, EventArgs e)
        {
            admin_giris f = new admin_giris();
            f.Show();
            this.Hide();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            baglanti.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            baglanti.Close();
        }
    }
}
