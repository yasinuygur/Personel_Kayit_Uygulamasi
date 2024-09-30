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

namespace Personel_Kayit_Uygulamasi
{
    public partial class Frmsistatistik : Form
    {
        public Frmsistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MASTER;Initial Catalog=PersonelDB;Integrated Security=True;Encrypt=False");
        private void Frmsistatistik_Load(object sender, EventArgs e)
        {
            //toplam personel sayısı
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("select count(*) from tbl_personel", baglanti);
            SqlDataReader reader1 = komut1.ExecuteReader();
            while (reader1.Read()) 
            {
                lblpersayisi.Text = reader1[0].ToString();
            }
            baglanti.Close();

            //evli personel sayısı

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand(" select count(*) from tbl_personel where personeldurum=1",baglanti);
            SqlDataReader r2 = komut2.ExecuteReader();
            while (r2.Read())
            {
                lblevlisayisi.Text = r2[0].ToString();
            }
            baglanti.Close();

            //bekar sayısı
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand(" select count(*) from tbl_personel where personeldurum=0", baglanti);
            SqlDataReader r3 = komut3.ExecuteReader();
            while (r3.Read())
            {
                lblbekarsayisi.Text = r3[0].ToString();
            }
            baglanti.Close();


            //farklı şehir
            baglanti.Open();

            SqlCommand komut4 = new SqlCommand(" select count(distinct(personelsehir)) from tbl_personel", baglanti);
            SqlDataReader r4 = komut4.ExecuteReader();
            while (r4.Read())
            {
                lblsehirsayisi.Text = r4[0].ToString();
            }
            baglanti.Close();


            //toplam maaş
            baglanti.Open();

            SqlCommand komut5 = new SqlCommand(" select sum(personelmaas) from tbl_personel", baglanti);
            SqlDataReader r5 = komut5.ExecuteReader();
            while (r5.Read())
            {
                lbltoplammaas.Text = r5[0].ToString();
            }
            baglanti.Close();



            //ortalama maaş
            baglanti.Open();

            SqlCommand komut6 = new SqlCommand(" select avg(personelmaas) from tbl_personel", baglanti);
            SqlDataReader r6 = komut6.ExecuteReader();
            while (r6.Read())
            {
                lblortalamamaas.Text = r6[0].ToString();
            }
            baglanti.Close();
        }
    }
}
