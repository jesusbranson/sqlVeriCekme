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
    public partial class frmGrafikler : Form
    {
        public frmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1R41UNM\\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True");
        private void frmGrafikler_Load(object sender, EventArgs e)
        {

            // sehiler grafiği
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select perSEHİR,Count(*) From tbl_Personel Group By perSEHİR",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            // maas grafiği

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select perMESLEK,avg(PerMAAS) From tbl_Personel group by perMESLEK", baglanti);
              SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek Maaş"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();


        }
    }
}
