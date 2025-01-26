using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakeData;

namespace OOPInheritance03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Ogrenci> oList = new List<Ogrenci>();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Ogrenci o = new Ogrenci();

                o.Id = i;
                o.Ad = NameData.GetFirstName();
                o.Soyad = NameData.GetSurname();
                o.BolumId = NumberData.GetNumber(1,10);
                o.Tckn = NumberData.GetNumber(12345675, 99999999);
                o.Adres.Cadde = PlaceData.GetStreetName();
                o.Adres.Sokak = NumberData.GetNumber(200).ToString();
                oList.Add(o);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oList;
            dataGridView1.Columns[5].Visible = false;
        }
        Ogrenci SecilenOgrenci;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label1.Text = dataGridView1.Rows.Count.ToString();
            label2.Text = dataGridView1.CurrentCell.Value.ToString();

            SecilenOgrenci = dataGridView1.CurrentRow.DataBoundItem as Ogrenci;

            txtAd.Text = SecilenOgrenci.Ad;
            txtSoyad.Text = SecilenOgrenci.Soyad;
            txtTc.Text = SecilenOgrenci.Tckn.ToString();

            listBox1.Items.Clear();

            foreach (var item in SecilenOgrenci.GetAdres())
            {
                listBox1.Items.Add(item);
            }
            listBox2.Items.Clear();
            foreach (var item in SecilenOgrenci.GetAdres1())
            {
                listBox2.Items.Add(item);
            }

        }
    }
}
