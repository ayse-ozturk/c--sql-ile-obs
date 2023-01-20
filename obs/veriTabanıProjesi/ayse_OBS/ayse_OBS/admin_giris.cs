using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Basılan butonlarla istelinen formlara geçmesini sağlar
namespace ayse_OBS
{
    public partial class admin_giris : Form
    {
        public admin_giris()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
           ogrenci form2 = new ogrenci();//ogrenci formundan form2 nesnesi oluşturulur 
            form2.Show();//form2 nesnesi açılır
            this.Hide();//bulunduğun formu gizle
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dersler form2 = new dersler();
            form2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kayit form2 = new kayit();
            form2.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            sifbilgi form2 = new sifbilgi();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            harc form2 = new harc();
            form2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ogekle ogekle = new ogekle();
            ogekle.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ogOzluk ogozluk = new ogOzluk();
            ogozluk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dersAtama dersAtama = new dersAtama();
            dersAtama.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            giris form1 = new giris();
            form1.Show();
            this.Hide();
        }
    }
}
