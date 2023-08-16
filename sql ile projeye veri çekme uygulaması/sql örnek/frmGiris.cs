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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1R41UNM\\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * From tbl_Yönetici Where kullanıcıAD=@p1 and Sifre=@p2", baglanti);
            komut1.Parameters.AddWithValue("@p1", txtKULLANICIAD.Text);
            komut1.Parameters.AddWithValue("@p2", txtSİFRE.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            if(dr1.Read())
            {
                FRManaform form = new FRManaform();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı veya hatalı şifre");
            }
            baglanti.Close();
        }
    }
}
