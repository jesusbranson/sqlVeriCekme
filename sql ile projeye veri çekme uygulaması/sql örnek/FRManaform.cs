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
    public partial class FRManaform : Form
    {
        public FRManaform()
        {
            InitializeComponent();
        }

         SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1R41UNM\\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True");
        void temizle()
        {
            txtAD.Text = "";
            txtSOYAD.Text = "";
            txtMESLEK.Text = "";
            txtID.Text = "";
            cmbSEHİR.Text = "";
            mskMAAS.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAD.Focus();
        }

        private void btnLİSTELE_Click(object sender, EventArgs e)
        {
            this.tbl_PERSONELTableAdapter.Fill(this.personelDataSet.tbl_PERSONEL);
        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_PERSONEL (perAD,perSOYAD,perSEHİR,perMESLEK,perMAAS,perDURUM) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2",txtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3",cmbSEHİR.Text);
            komut.Parameters.AddWithValue("@p4", txtMESLEK.Text);
            komut.Parameters.AddWithValue("@p5", mskMAAS.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kaydedildi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                label8.Text = "False";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void btnTEMİZLE_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            txtAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            cmbSEHİR.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            mskMAAS.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            txtMESLEK.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton2.Checked = true;
            }
            if(label8.Text == "False")
            { 
                radioButton1.Checked = true; 
            }
        }

        private void btnSİL_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From tbl_Personel Where perID=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1",txtID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnGÜNCELLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand güncelle = new SqlCommand("Update tbl_Personel Set perAD=@g1, perSOYAD=@g2, perSEHİR=@g3, perMAAS=@g4,perDURUM=@g5, perMESLEK=@g6 where perID = @g7",baglanti);
            güncelle.Parameters.AddWithValue("@g1", txtAD.Text);
            güncelle.Parameters.AddWithValue("@g2", txtSOYAD.Text);
            güncelle.Parameters.AddWithValue("@g3", cmbSEHİR.Text);
            güncelle.Parameters.AddWithValue("@g4", mskMAAS.Text);
            güncelle.Parameters.AddWithValue("@g5", label8.Text);
            güncelle.Parameters.AddWithValue("@g6", txtMESLEK.Text);
            güncelle.Parameters.AddWithValue("@g7", txtID.Text);

            güncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgi Güncellendi");
        }

        private void btnİSTATİSTİK_Click(object sender, EventArgs e)
        {
            frmistatistik frmistatistik = new frmistatistik();
            frmistatistik.Show();
        }

        private void btnGRAFİK_Click(object sender, EventArgs e)
        {
            frmGrafikler FRG = new frmGrafikler();
            FRG.Show();
        }
    }
}
