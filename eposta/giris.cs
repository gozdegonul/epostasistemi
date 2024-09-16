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

namespace eposta
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Gozde_Huawei;Initial Catalog=epostagelen;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select EPOSTA , SİFRE from KİSİLER WHERE EPOSTA=@P1 AND SİFRE=@P2",baglanti);
            cmd.Parameters.AddWithValue("@P1", txteposta.Text);
            cmd.Parameters.AddWithValue("@P2", txtsifre.Text);
            SqlDataReader dr  = cmd.ExecuteReader();
            if(dr.Read())
            {
                txteposta.Text = dr[0].ToString();
                txtsifre.Text = dr[1].ToString();

                Form1 frm = new Form1();
                frm.eposta = txteposta.Text;
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            baglanti.Close();






         
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void lblhesap_Click(object sender, EventArgs e)
        {
            kayitol ko = new kayitol();
            ko.ShowDialog();
        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {
            
       
          
            txtsifre.UseSystemPasswordChar = true;
           
        }

        private void txteposta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtsifre_Click(object sender, EventArgs e)
        {
            if (txtsifre.Text == "Şifre")
            {
                txtsifre.Text = "";
                txtsifre.SelectionStart = 0;
            }

        }

        private void txteposta_Click(object sender, EventArgs e)
        {
            if (!txteposta.Text.EndsWith("@easymail.com"))
            {
                txteposta.Text = "";
                txteposta.SelectionStart = 0;
                txteposta.Text = txteposta.Text + "@easymail.com";
                
            }
        }
    }
}
