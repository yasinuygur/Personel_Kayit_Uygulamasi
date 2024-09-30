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
using System.Diagnostics.Eventing.Reader;

namespace Personel_Kayit_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MASTER;Initial Catalog=PersonelDB;Integrated Security=True;Encrypt=False");

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPerAd.Focus();
            this.tbl_PersonelTableAdapter.Fill(this.personelDBDataSet.Tbl_Personel);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelDBDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PersonelAd, PersonelSoyad,personelsehir,personelmaas,personelmeslek,personeldurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", txtPerAd.Text);
            komut.Parameters.AddWithValue("@p2", txtPerSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbPerSehir.Text);
            komut.Parameters.AddWithValue("@p5", txtPerMeslek.Text);
            komut.Parameters.AddWithValue("@p4", mskTxtPerMaas.Text);
            komut.Parameters.AddWithValue("@p6", label1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        void Temizle()
        {
            txtPerAd.Text = "";
            txtPerSoyad.Text = "";
            txtPerMeslek.Text = "";
            mskTxtPerMaas.Text = "";
            cmbPerSehir.Text = "";
            txtPerId.Text = "";
            rdbtnBekar.Checked = false;
            rdbtnEvli.Checked = false;
            txtPerAd.Focus();
        }

        private void rdbtnEvli_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnEvli.Checked)
            {
                label1.Text = "True";
            }
        }

        private void rdbtnBekar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnBekar.Checked)
            {
                label1.Text= "False";
            }
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtPerId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtPerAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtPerSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbPerSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTxtPerMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtPerMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text == "True")
            {
                rdbtnEvli.Checked = true;
                rdbtnBekar.Checked = false;
            }
            else if (label1.Text == "False") {
                rdbtnBekar.Checked = true;
                rdbtnEvli.Checked = false;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutSil = new SqlCommand("Delete from tbl_Personel where personelid=@k1",baglanti);
            komutSil.Parameters.AddWithValue("@k1",txtPerId.Text);
            komutSil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutGuncelle = new SqlCommand("update tbl_personel set personelad=@a2, personelsoyad=@a3, personelsehir=@a4, personelmaas=@a5,personeldurum=@a6, personelmeslek=@a7 where personelid=@a1", baglanti);
            komutGuncelle.Parameters.AddWithValue("@a1",txtPerId.Text);
            komutGuncelle.Parameters.AddWithValue("@a2",txtPerAd.Text);
            komutGuncelle.Parameters.AddWithValue("@a3",txtPerSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@a4",cmbPerSehir.Text);
            komutGuncelle.Parameters.AddWithValue("@a5",mskTxtPerMaas.Text);
            komutGuncelle.Parameters.AddWithValue("@a6",label1.Text);
            komutGuncelle.Parameters.AddWithValue("@a7",txtPerMeslek.Text);
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            Frmsistatistik frmsistatistik = new Frmsistatistik();

            frmsistatistik.Show();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg = new FrmGrafikler();

            frg.Show();
        }
    }
}
