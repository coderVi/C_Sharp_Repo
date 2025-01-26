using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPInheritance2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Ogrenci> ogr = new List<Ogrenci>();

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();

            ogrenci.ID = 1;
            ogrenci.Ad = "Coder";
            ogrenci.Soyad = "Vi";
            ogr.Add(ogrenci);

            Ogrenci ogrenci0 = new Ogrenci();

            ogrenci0.ID = 2;
            ogrenci0.Ad = "Coder0";
            ogrenci0.Soyad = "Vi0";
            ogr.Add(ogrenci0);

            Ogrenci ogrenci01 = new Ogrenci();

            ogrenci01.ID = 3;
            ogrenci01.Ad = "Coder01";
            ogrenci01.Soyad = "Vi01";
            ogr.Add(ogrenci01);

            listBox1.DataSource = ogr;
            listBox1.DisplayMember = "Ad"; // Front
            listBox1.ValueMember ="ID"; // Back


            comboBox1.DataSource = ogr;
            comboBox1.DisplayMember = "Ad";
            comboBox1.ValueMember ="ID";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ogrenci ogr = listBox1.SelectedItem as Ogrenci;

            textBox1.Text = ogr.ID.ToString();
            textBox2.Text = ogr.Ad;
            textBox3.Text = ogr.Soyad;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci(textBox2.Text,textBox3.Text);

            button2.Text = o.Ad;
        }
    }
}
