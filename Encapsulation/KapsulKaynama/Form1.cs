using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapsulKaynama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Sicaklik sicaklik = new Sicaklik();
            try
            {
                sicaklik.Isi = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Hatalı Giriş " + ex.Message);
            }
            MessageBox.Show(sicaklik.Isi.ToString());

        }
    }
}
