using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance2
{
    internal class Ogrenci : Kisi
    {
        public string AdSoyad { get; set; }

        //Constructor
        public Ogrenci()
        {
            Ad = "Samet";
            Soyad = "CoderV!";
            AdSoyad = GetFullName();
        }

        public Ogrenci(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            AdSoyad= GetFullName();
        }

        public string GetFullName()
        {
            return Ad + " " + Soyad;
        }
    }
}
