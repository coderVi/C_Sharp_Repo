using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPKapsul
{
    public partial class Form1 : Form
    {
        public Form1() //constractor "KURUCU METHOT"
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();

            ogr.Ad = "yılmaz";
            ogr.Soyad = "türk";
            label4.Text = ogr.AdSoyad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Tckn = long.Parse(textBox1.Text);
            ogr.Ad = textBox2.Text;
            ogr.Soyad = textBox3.Text;

            ListViewItem kayit = new ListViewItem();
            kayit.Text = ogr.Tckn.ToString();
            kayit.SubItems.Add(ogr.Ad);
            kayit.SubItems.Add(ogr.Soyad);
            listView1.Items.Add(kayit);
        }
    }
}
