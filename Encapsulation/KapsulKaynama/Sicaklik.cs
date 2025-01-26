using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsulKaynama
{
    internal class Sicaklik
    {
        int isi;
        int basıc;

        public int Isi {
            get { return isi; }
            set 
            {
                if (value <= 100 && value >= 0)
                {
                    isi = value;
                }
                else if (value < 0)
                {
                    isi = 0;
                    throw new Exception("Fazla Soğuk");
                }
                else 
                {
                    isi = 100;
                    throw new Exception("Fazla Sıcak");
                }
            } 
        }
    }
}
