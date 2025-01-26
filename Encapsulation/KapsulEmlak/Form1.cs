using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapsulEmlak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Emlak> list = new List<Emlak>();
        private void button1_Click(object sender, EventArgs e)
        {
            Emlak emlak = new Emlak();
            emlak.Semt = txtSemt.Text;
            emlak.OdaSayisi = Convert.ToInt32(txtOda.Text);
            emlak.KatNo = Convert.ToInt32(txtKat.Text);
            emlak.Alan = Convert.ToInt32(txtAlan.Text);
            ListViewItem kayit = new ListViewItem();
            kayit.Text = emlak.Semt;
            kayit.SubItems.Add(emlak.OdaSayisi.ToString());
            kayit.SubItems.Add(emlak.KatNo.ToString());
            kayit.SubItems.Add(emlak.Alan.ToString());
            listView1.Items.Add(kayit);

            list.Add(emlak);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;

            txtAlan.Clear();
            txtKat.Clear();
            txtOda.Clear();
            txtSemt.Clear();
            

        }
        int seciliAlan;
        void EkranaYaz()
        {
            MessageBox.Show(seciliAlan.ToString());
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Emlak seciliOlan = dataGridView1.CurrentRow.DataBoundItem as Emlak;

            seciliAlan = seciliOlan.Alan;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EkranaYaz();
        }
    }
}
