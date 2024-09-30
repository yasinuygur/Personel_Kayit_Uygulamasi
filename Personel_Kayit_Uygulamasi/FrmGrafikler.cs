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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MASTER;Initial Catalog=PersonelDB;Integrated Security=True;Encrypt=False");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //grafik sehirler
            baglanti.Open();

            SqlCommand komutg1 = new SqlCommand("select personelsehir,count(*) from tbl_personel group by personelsehir", baglanti);

            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            //grafik maas-meslek
            baglanti.Open();

            SqlCommand komutg2 = new SqlCommand("select personelmeslek,avg(personelmaas) from tbl_personel group by personelmeslek", baglanti);

            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();

        }
    }
}
