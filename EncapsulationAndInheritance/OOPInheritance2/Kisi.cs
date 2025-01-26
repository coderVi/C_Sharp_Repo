using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance2
{
    internal class Kisi
    {
        string ad, soyad;
        public int ID { get; set; }
        public string Ad { get => ad; set => ad = value.ToUpper(); }
        public string Soyad { get=>soyad; set => soyad= value.ToUpper(); }
    }
}
 