using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKapsul
{
    internal class Ogrenci
    {
        private string _ad; //Field
        private string _soyad;
        private long _tckn;

        

        //Kapsülleme
        public string Ad 
        {
            get { return _ad; }

            set { _ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); } 
        }
        //Quick Actions ile ekleme
        public string Soyad { get => _soyad; set => _soyad = value.ToUpper(); }
        public long Tckn { get => _tckn; set => _tckn = Math.Abs(value); }

        public string AdSoyad()
        {
            return _ad + " " + _soyad;
        }
    }
}
