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
using System.IO;

namespace eposta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Gozde_Huawei;Initial Catalog=epostagelen;Integrated Security=True");
        public string eposta;
        void gelen()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("Select GÖNDEREN,KONU,İÇERİK from eposta WHERE ALICI = @alici", baglanti);
            cmd.SelectCommand.Parameters.AddWithValue("@alici", lbleposta.Text);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

   

        void giden()
        {


            SqlDataAdapter cmd1 = new SqlDataAdapter("Select ALICI,KONU,İÇERİK from eposta WHERE GÖNDEREN = @gönderen"  , baglanti);
            cmd1.SelectCommand.Parameters.AddWithValue("@gönderen", lbleposta.Text);
            DataTable dt = new DataTable();
            cmd1.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panelgiden.BackColor=Color.WhiteSmoke;
            lblgiden.Visible=true;
           
            
            lbleposta.Text =eposta;
            lbleposta.Visible=false;

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select RESİM from KİSİLER where EPOSTA=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", eposta);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0] != DBNull.Value) 
                {
                    byte[] img = (byte[])dr[0];
                    MemoryStream ms = new MemoryStream(img);
                    pb1.Image = Image.FromStream(ms);
                }
                
            }

            baglanti.Close();

            gelen();
        }

      
        private void lblgiden_Click(object sender, EventArgs e)
        {
            giden();
            panelgiden.BackColor= Color.Azure;
            panelgelen.BackColor = Color.WhiteSmoke;
            lblgelen.ForeColor = Color.Gray;
            lblgiden.ForeColor = Color.Black;
        }

        private void lblgelen_Click(object sender, EventArgs e)
        {
            gelen();
            panelgelen.BackColor = Color.Azure;
            panelgiden.BackColor = Color.WhiteSmoke;
            lblgiden.ForeColor = Color.Gray;
            lblgelen.ForeColor = Color.Black;
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            epostagonder gdr = new epostagonder();
            gdr.eposta = eposta;
            gdr.ShowDialog();

        }

        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string searchQuery = txtarama.Text; 

            if(panelgelen.BackColor == Color.Azure)
            {
                baglanti.Open();

                SqlDataAdapter cmd = new SqlDataAdapter("SELECT GÖNDEREN,KONU,İÇERİK FROM eposta WHERE ALICI =@alici AND (GÖNDEREN LIKE '%' + @search + '%' OR KONU LIKE '%' + @search + '%' OR İÇERİK LIKE '%' + @search + '%')", baglanti);
                cmd.SelectCommand.Parameters.AddWithValue("@alici", lbleposta.Text);
                cmd.SelectCommand.Parameters.AddWithValue("@search", searchQuery);

                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;

                baglanti.Close();
            }


            else if (panelgiden.BackColor == Color.Azure)
            {
                baglanti.Open();

                SqlDataAdapter cmd = new SqlDataAdapter("SELECT ALICI,KONU,İÇERİK FROM eposta WHERE GÖNDEREN = @gonderen AND (ALICI LIKE '%' + @search + '%' OR KONU LIKE '%' + @search + '%' OR İÇERİK LIKE '%' + @search + '%')", baglanti);
                cmd.SelectCommand.Parameters.AddWithValue("@gonderen", lbleposta.Text);
                cmd.SelectCommand.Parameters.AddWithValue("@search", searchQuery);

                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;

                baglanti.Close();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Problemlerini easy@mail.com adresine iletiniz.", "Yardım", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kisiayar ka = new kisiayar();
            ka.eposta = eposta;
            ka.ShowDialog();
        }
    }
}
