using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] vites = new string[2] { "Otomatik", "Manuel" };
        string[] yakit = new string[3] { "Dizel", "Benzin", "LPG" };

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                #region Otomobil
                string[] otoTur = new string[3] { "Sedan", "Hatchback", "Station Wagon" };
                foreach (var item in otoTur)
                {
                    cmbOtoTur.Items.Add(item);
                }
                foreach (var item in vites)
                {
                    cmbOtoVites.Items.Add(item);
                }
                foreach (var item in yakit)
                {
                    cmbOtoYakit.Items.Add(item);
                }
                #endregion
                #region Kamyon
                foreach (var item in vites)
                {
                    cmbKVites.Items.Add(item);
                }
                foreach (var item in yakit)
                {
                    cmbKYakit.Items.Add(item);
                }
                #endregion
                #region Otobüs
                foreach (var item in vites)
                {
                    cmbOViter.Items.Add(item);
                }
                foreach (var item in yakit)
                {
                    cmbOYakit.Items.Add(item);
                }
                #endregion
                #region İş Makinası
                string[] isMakina = new string[4] { "Portlift", "Dozer", "Digger", "Diğer" };
                foreach (var item in isMakina)
                {
                    cmbIsMakine.Items.Add(item);
                }
                foreach(var item in yakit)
                {
                    cmbIsYakit.Items.Add(item);
                }
                foreach (var item in vites)
                {
                    cmbIsVites.Items.Add(item);
                }
                lblDiger.Hide();
                txtDiger.Hide();
                cmbIsMakine.SelectedIndexChanged += cmbIsMakine_SelectedIndexChanged;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Otomobil
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Otomobil> otoList = new List<Otomobil>();
                Otomobil o = new Otomobil();

                o.OtoTur = cmbOtoTur.SelectedItem.ToString();
                o.VitesTuru = cmbOtoVites.SelectedItem.ToString();
                o.YakitTipi = cmbOtoYakit.SelectedItem.ToString();
                o.Renk = txtOtoRenk.Text;
                o.Model = Convert.ToInt32(txtOtoModel.Text);

                otoList.Add(o);
                dataGridView1.DataSource = otoList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        //Kamyon
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<Kamyon> kamyonList = new List<Kamyon>();
                Kamyon k = new Kamyon();
                k.YakitTipi = cmbKYakit.SelectedItem.ToString();
                k.VitesTuru = cmbKVites.SelectedItem.ToString();
                k.TekerSayisi = Convert.ToInt32(txtKTeker.Text);
                k.DamperKapasite = Convert.ToInt32(txtKDamper.Text);
                k.Renk = txtKRenk.Text;
                k.Model = Convert.ToInt32(txtKModel.Text);
                kamyonList.Add(k);
                dataGridView2.DataSource = kamyonList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        //Otobüs
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Otobus otobus = new Otobus();
                List<Otobus>  obList = new List<Otobus>();
                otobus.Renk = txtORenk.Text;
                otobus.YakitTipi = cmbOYakit.SelectedItem.ToString();
                otobus.VitesTuru = cmbOViter.SelectedItem.ToString();
                otobus.KoltukSayisi = Convert.ToInt32(txtOKoltuk.Text);
                if (radioButton1.Checked)
                {
                    otobus.KonforTipi = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    otobus.KonforTipi=radioButton2.Text;
                }
                otobus.Model = Convert.ToInt32(txtOModel.Text);
                obList.Add(otobus);

                dataGridView3.DataSource = obList;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        //İş Makinesi
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                List<IsMakinasi> i = new List<IsMakinasi>();
                IsMakinasi im = new IsMakinasi();
                if(cmbIsMakine.SelectedItem.ToString() != "Diğer")
                {
                    im.MakinaTur = cmbIsMakine.SelectedItem.ToString();
                }
                else if(cmbIsMakine.SelectedItem.ToString() == "Diğer")
                {
                    im.MakinaTur = txtDiger.Text;
                }
                im.VitesTuru = cmbIsVites.SelectedItem.ToString();
                im.YakitTipi = cmbIsYakit.SelectedItem.ToString();
                im.Renk = txtIsRenk.Text;
                im.Model = Convert.ToInt32(txtIsModel.Text);

                i.Add(im);

                dataGridView4.DataSource = i;
            }
            catch(Exception ex) {  MessageBox.Show(ex.Message); }
        }

        private void cmbIsMakine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIsMakine.SelectedItem != null && cmbIsMakine.SelectedItem.ToString() == "Diğer")
            {
                lblDiger.Show();
                txtDiger.Show();
            }
            else
            {
                lblDiger.Hide();
                txtDiger.Hide();
            }
        }
    }
}
