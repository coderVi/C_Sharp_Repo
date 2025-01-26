using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOP_ADO.NET_SQL
{
    public partial class Anasayfa : Form
    {
        public string KullaniciAdi { get; set; }
        private SqlConnection conn;

        public Anasayfa()
        {
            InitializeComponent();
            conn = new SqlConnection(new DbConnetionString().Connetion);
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            label5.Text = KullaniciAdi;
            label6.Text = DateTime.Now.ToString("HH:mm:ss");
            timer1.Interval = 1000;
            timer1.Start();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            // Tür combobox'ı doldurma
            SqlCommand cmd = new SqlCommand("SELECT ID, TurAdi FROM Tur", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);

            cmbKATurSecim.DataSource = dt;
            cmbKATurSecim.DisplayMember = "TurAdi";
            cmbKATurSecim.ValueMember = "ID";

            // Kitap combobox'ı doldurma
            SqlCommand cmd2 = new SqlCommand("SELECT IsbnNO, KitapAdi FROM tbl_kitaplar", conn);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(rd2);

            cmbKAkitapSecim.DataSource = dt2;
            cmbKAkitapSecim.DisplayMember = "KitapAdi";
            cmbKAkitapSecim.ValueMember = "IsbnNO";
            Listele();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT tbl_kitaplar.IsbnNO, tbl_kitaplar.KitapAdi, Tur.TurAdi, tbl_kitaplar.YazarAdi FROM tbl_kitaplar JOIN Tur ON tbl_kitaplar.Tur = Tur.ID", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Tür ekleme kontrolü
                SqlCommand cmdCheckTur = new SqlCommand("SELECT COUNT(*) FROM Tur WHERE TurAdi = @p1", conn);
                cmdCheckTur.Parameters.AddWithValue("@p1", txtTur.Text);
                int count = (int)cmdCheckTur.ExecuteScalar();

                int turId;

                if (count == 0)
                {
                    // Yeni tür ekleniyorsa
                    SqlCommand insertTurCmd = new SqlCommand("INSERT INTO Tur (TurAdi) VALUES (@p1); SELECT SCOPE_IDENTITY()", conn);
                    insertTurCmd.Parameters.AddWithValue("@p1", txtTur.Text);
                    turId = Convert.ToInt32(insertTurCmd.ExecuteScalar());
                }
                else
                {
                    // Tür zaten varsa direk TurId'yi al
                    SqlCommand cmdTurId = new SqlCommand("SELECT ID FROM Tur WHERE TurAdi = @p1", conn);
                    cmdTurId.Parameters.AddWithValue("@p1", txtTur.Text);
                    turId = (int)cmdTurId.ExecuteScalar();
                }

                // Kitap ekleme işlemi
                SqlCommand insertKitapCmd = new SqlCommand("INSERT INTO tbl_kitaplar (IsbnNO, KitapAdi, Tur, YazarAdi) VALUES (@p1, @p2, @p3, @p4)", conn);
                insertKitapCmd.Parameters.AddWithValue("@p1", txtIsbn.Text);
                insertKitapCmd.Parameters.AddWithValue("@p2", txtKitapAdi.Text);
                insertKitapCmd.Parameters.AddWithValue("@p3", turId); // Tür ID
                insertKitapCmd.Parameters.AddWithValue("@p4", txtYazarAd.Text);
                insertKitapCmd.ExecuteNonQuery();

                // DataGridView güncellemesi
                Listele();

                MessageBox.Show("Ekleme Başarılı");

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
    }
}
