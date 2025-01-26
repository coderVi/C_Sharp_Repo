using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SnfTemel snfTemel = new SnfTemel();
            snfTemel.mtdMesaj("Selam");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SnfTuremis snfTuremis = new SnfTuremis();
            snfTuremis.mtdMesaj("Bu bir Poliforfizm örneğidir.");
        }
    }
}
