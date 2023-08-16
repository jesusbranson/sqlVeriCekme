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

namespace sql_örnek
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1R41UNM\\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True");

        private void frmistatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand istatistik = new SqlCommand("select count(*) From tbl_Personel", baglanti);

            // toplam personel sayısı

            SqlDataReader dr1 = istatistik.ExecuteReader();
            while (dr1.Read())
            {
                label2.Text = dr1[0].ToString();
            }
            baglanti.Close();


            // evli personel sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) From tbl_Personel where perDURUM = 1", baglanti);

            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label6.Text = dr2[0].ToString();
            }
            baglanti.Close();

            // BEKAR PERSONEL SAYISI
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) From tbl_Personel where perDURUM = 0", baglanti);

            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label7.Text = dr3[0].ToString();
            }
            baglanti.Close();

          


            // kaç farklı şehirde yaşayanlar
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Count(distinct(perSEHİR)) From tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();

            while(dr5.Read())
            {
                label8.Text = dr5[0].ToString();
            }
            baglanti.Close();


            // toplam maaş

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Sum(perMAAS) From tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();

            while(dr6.Read())
            {
                label11.Text = dr6[0].ToString();
            }
            baglanti.Close();

            // ortalama maaş
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select Avg(perMAAS) From tbl_Personel",baglanti);
            SqlDataReader dr7 = komut7.ExecuteReader();

            while(dr7.Read())
            {
                label12.Text = dr7[0].ToString();
            }
            baglanti.Close();   

        }
    }
}
