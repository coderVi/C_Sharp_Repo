using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfizm
{
    internal class SnfTemel
    {
        public virtual void mtdMesaj(string icerik)
        {
            MessageBox.Show(icerik);
        }
    }

    internal class SnfTuremis : SnfTemel
    {
        public override void mtdMesaj(string icerik)
        {
            MessageBox.Show(icerik.ToUpper());  //Türemiş olan ovirrede edilerek gösterilir
        }
    }
}
