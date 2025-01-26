using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_ADO.NET_SQL
{
    public partial class GirisVeKayit : Form
    {
        public GirisVeKayit()
        {
            InitializeComponent();
        }

        static DbConnetionString connetionString = new DbConnetionString();
        SqlConnection conn = new SqlConnection(connetionString.Connetion);

        UsersInfo ui = new UsersInfo();
        private void btnPKkayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                ui.PKAdSoyad = txtPKadSoyad.Text;
                ui.PKKadi = txtPKkadi.Text;
                ui.PKSifre = txtPKsifre.Text;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    
                }
                SqlCommand kullaniciKontrol = new SqlCommand("SELECT COUNT(*) FROM tbl_Users WHERE Kadi=@p1 AND Sifre=@p2", conn);
                kullaniciKontrol.Parameters.AddWithValue("@p1", txtKYkadi.Text);
                kullaniciKontrol.Parameters.AddWithValue("@p2", txtKYsifre.Text);
                int count = Convert.ToInt32(kullaniciKontrol.ExecuteScalar());

                if (count > 0)
                {
                    SqlCommand kisiSorgulama = new SqlCommand("SELECT COUNT(*) FROM tbl_Users WHERE AdSoyad=@p1 AND Kadi=@p2", conn);
                    kisiSorgulama.Parameters.AddWithValue("@p1", ui.PKAdSoyad);
                    kisiSorgulama.Parameters.AddWithValue("@p2", ui.PKKadi);
                    count = Convert.ToInt32(kisiSorgulama.ExecuteScalar());

                    if (count < 1)
                    {
                        if (ui.PKSifre == txtPKsifreRPT.Text)
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Users(AdSoyad,Kadi,Sifre) VALUES (@p1,@p2,@p3)", conn);
                            cmd.Parameters.AddWithValue("@p1", ui.PKAdSoyad);
                            cmd.Parameters.AddWithValue("@p2", ui.PKKadi);
                            cmd.Parameters.AddWithValue("@p3", ui.PKSifre);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Kayıt Yapıldı");
                        }
                        else
                        {
                            MessageBox.Show("Personel Kayıt Şifreleri Uyuşmuyor");
                            txtPKsifre.Clear();
                            txtPKsifreRPT.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Zaten Tanımlı");
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt yapan kişinin kullanıcı adı veya şifresi hatalı");
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            txtKGsifre.PasswordChar = txtKGsifre.PasswordChar == '*' ? '\0' : '*';
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            ui.KGKadi = txtKGkadi.Text;
            ui.KGSifre = txtKGsifre.Text;

            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    
                }
                SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM tbl_Users WHERE Kadi=@p1 AND Sifre=@p2", conn);
                cmd.Parameters.AddWithValue("@p1", ui.KGKadi);
                cmd.Parameters.AddWithValue("@p2", ui.KGSifre);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Giriş Başarılı");
                    Anasayfa anasayfa = new Anasayfa();
                    anasayfa.KullaniciAdi = ui.KGKadi;
                    anasayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
