using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance03
{
    internal class TemelInsan
    {
        public int Id { get; set; }
        public long Tckn { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Adres Adres { get; set; }

        public TemelInsan()
        {

            Adres = new Adres();
        }
        public List<string> GetAdres()
        {
            List<string> alist = new List<string>();
            string satir1 = "Sn. " + Ad + " " + Soyad;
            alist.Add(satir1);
            string satir2 = Adres.Cadde;
            alist.Add(satir2);
            string satir3 = Adres.Sokak + " "+ Adres.KapiNo;
            alist.Add(satir3);
            return alist;

        }
        public string[] GetAdres1()
        {
            string[] adizi = new string[3];
            adizi[0] = "Sn. " + Ad + " "+ Soyad;
            adizi[1] = Adres.Cadde;
            adizi[2] = Adres.Sokak + Adres.KapiNo;
            return adizi;
        }

    }
}
