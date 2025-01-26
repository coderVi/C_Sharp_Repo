using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapsulNotGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            List<Ogrenci> list = new List<Ogrenci>();
            o.OgrName = textBox2.Text;
            o.OgrSurname = textBox3.Text;
            o.OgrNo = Convert.ToInt32(textBox1.Text);

            o.Not1 = Convert.ToInt32(textBox4.Text);
            o.Not2 = Convert.ToInt32(textBox5.Text);
            o.Not3 = Convert.ToInt32(textBox6.Text);

            list.Add(o);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }
    }
}
