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

namespace eposta
{
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Gozde_Huawei;Initial Catalog=epostagelen;Integrated Security=True");
        private void kayitol_Load(object sender, EventArgs e)
        {

        }

        private void lblolustur_Click(object sender, EventArgs e)
        {



            baglanti.Open();
            SqlCommand posta = new SqlCommand("Select EPOSTA from KİSİLER where EPOSTA ='" + txteposta.Text + "'", baglanti);
            SqlDataReader dr = posta.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bu eposta alınmış. Lütfen yeni bir eposta adresi giriniz.","Hatalı Eposta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txteposta.Text=string.Empty;
                return;
            }
            baglanti.Close();


            if (txteposta.Text == string.Empty || txteposta.Text == "E-Posta")
            {
                MessageBox.Show("Lütfen eposta giriniz.", "Eksik Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txteposta.Text=string.Empty;
                txteposta.Focus();
                return;
            }


            if (txtsifre.Text == string.Empty || txtsifre.Text == "Şifre")
            {
                MessageBox.Show("Lütfen şifre giriniz.", "Eksik Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsifre.Text = string.Empty;
                txtsifre.Focus();
                return;
            }

          
           
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into KİSİLER (AD,SOYAD,EPOSTA,SİFRE) values (@p1,@p2,@p3,@p4)", baglanti);
                cmd.Parameters.AddWithValue("@p1", txtad.Text);
                cmd.Parameters.AddWithValue("@p2", txtsoyad.Text);
                cmd.Parameters.AddWithValue("@p3", txteposta.Text);
                cmd.Parameters.AddWithValue("@p4", txtsifre.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hesabınız başarı ile oluşturulmuştur.", "Başarılı Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                baglanti.Close();
            
           
        }
    }
}
