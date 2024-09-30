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
    public partial class Frmgiris : Form
    {
        public Frmgiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MASTER;Initial Catalog=PersonelDB;Integrated Security=True;Encrypt=False");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from tbl_yonetici where kullaniciad=@p1 and sifre=@p2",baglanti);

            komut.Parameters.AddWithValue("@p1",txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {

                Form1 frm = new Form1();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
            }

            baglanti.Close();
        }
    }
}
