using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSirketOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string personelTuru = cmbPersonel.SelectedItem.ToString();
                double.TryParse(txtKSayi.Text, out double kSayi);

                if (personelTuru == "Yönetici")
                {
                    Yönetici y = new Yönetici()
                    {
                        Name = txtAd.Text,
                        SurName = txtSoyad.Text,
                    };
                    ListViewItem l = new ListViewItem();
                    l.Text = y.Name;
                    l.SubItems.Add(y.SurName);
                    l.SubItems.Add(y.KHesap(Convert.ToInt32(txtKSayi.Text), Convert.ToInt32(txtTecrübe.Text)).ToString("F2"));
                    listView1.Items.Add(l);
                    
                }
                else if(personelTuru == "Öğretmen")
                {
                    Ogretmen y = new Ogretmen()
                    {
                        Name = txtAd.Text,
                        SurName = txtSoyad.Text,
                    };
                    ListViewItem l = new ListViewItem();
                    l.Text = y.Name;
                    l.SubItems.Add(y.SurName);
                    l.SubItems.Add(y.KHesap(Convert.ToInt32(txtKSayi.Text), Convert.ToInt32(txtTecrübe.Text)).ToString("F2"));
                    listView1.Items.Add(l);
                }
                else if (personelTuru == "Çalışan")
                {
                    Calisan y = new Calisan()
                    {
                        Name = txtAd.Text,
                        SurName = txtSoyad.Text,
                    };
                    ListViewItem l = new ListViewItem();
                    l.Text = y.Name;
                    l.SubItems.Add(y.SurName);
                    l.SubItems.Add(y.KHesap(Convert.ToInt32(txtKSayi.Text), Convert.ToInt32(txtTecrübe.Text)).ToString("F2"));
                    listView1.Items.Add(l);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
