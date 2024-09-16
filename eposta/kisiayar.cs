using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace eposta
{
    public partial class kisiayar : Form
    {
        public kisiayar()
        {
            InitializeComponent();
        }

        
     
        public string eposta;
       

        string resim;
        SqlConnection baglanti = new SqlConnection("Data Source=Gozde_Huawei;Initial Catalog=epostagelen;Integrated Security=True");
        private void lblpp_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpeg Dosyaları (*.jpeg)|*.jpeg|Jpg Dosyaları (*.jpg)|*.jpg|Png Dosyaları (*.png)|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resim = openFileDialog1.FileName;

            }
        }

        private void lblppkaydet_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(resim , FileMode.Open , FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] image = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();


            baglanti.Open();
            SqlCommand cmd = new SqlCommand("UPDATE KİSİLER SET RESİM = @p1 WHERE EPOSTA = @p2", baglanti);
            cmd.Parameters.AddWithValue("@p2", txteposta.Text);
            cmd.Parameters.Add("@p1", SqlDbType.Image, image.Length).Value = image;
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Profil Resminiz Başarı ile Güncellenmiştir. \n UYARI : PROFİL RESMİ GÜNCELLENMESİ HESABA TEKRAR GİRİŞ YAPILDIĞINDA GÖRÜNTÜLENİR", "Başarılı Profil Resmi Yüklenimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void kisiayar_Load(object sender, EventArgs e)
        {
            txteposta.Text = eposta;

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select AD , SOYAD , SİFRE , RESİM from KİSİLER where EPOSTA = @p1",baglanti);
            cmd.Parameters.AddWithValue("@p1",txteposta.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtad.Text = dr[0].ToString();
                txtsoyad.Text = dr[1].ToString();
                txtsifre.Text = dr[2].ToString();
                if (dr[3] != DBNull.Value) 
                {
                    byte[] img = (byte[])dr[3];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                }
               
            }
         
            baglanti.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("UPDATE KİSİLER SET  AD = @p1 , SOYAD = @p2 , SİFRE = @p3  WHERE EPOSTA = @p4", baglanti);
            cmd.Parameters.AddWithValue("@p4", txteposta.Text);
            cmd.Parameters.AddWithValue("@p1", txtad.Text);
            cmd.Parameters.AddWithValue("@p2", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", txtsifre.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Profiliniz başarı ile yüklenmiştir. \n UYARI : PROFİL RESMİ GÜNCELLENMESİ HESABA TEKRAR GİRİŞ YAPILDIĞINDA GÖRÜNTÜLENİR", "Başarılı Profil Güncellenmesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void lblcikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
