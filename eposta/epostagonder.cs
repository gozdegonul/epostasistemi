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
    public partial class epostagonder : Form
    {
        public epostagonder()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Gozde_Huawei;Initial Catalog=epostagelen;Integrated Security=True");

    
        public string eposta;

        private void epostagonder_Load(object sender, EventArgs e)
        {
            lblgondereneposta.Text = eposta;

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select AD , SOYAD from kisiler WHERE EPOSTA = @p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", lblgondereneposta.Text);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                lbladsoyad.Text = rdr[0].ToString() + " " + rdr[1].ToString();
            }
            baglanti.Close();
        }

        private void lblgonder_Click(object sender, EventArgs e)
        {
            if(txtalici.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Mail adresi giriniz.", "Mail Girimi" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into eposta (GÖNDEREN ,ALICI , KONU , İÇERİK ) values (@p1 , @p2 , @p3 , @p4)", baglanti);
                cmd.Parameters.AddWithValue("@p1", lblgondereneposta.Text);
                cmd.Parameters.AddWithValue("@p2", txtalici.Text);
                cmd.Parameters.AddWithValue("@p3", txtkonu.Text);
                cmd.Parameters.AddWithValue("@p4", richicerik.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Mailiniz başarı ile gönderilmiştir.", "Başarılı Mail Gönderimi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }

            
        }
    }
}
