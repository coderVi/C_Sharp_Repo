using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Accounting acc = new Accounting();

            acc.Name = "Samet";

            Student student = new Student();

            student.Name = "Veli";
            student.Surname = "Türk";

            MessageBox.Show(student.Name);

        }
    }
}
