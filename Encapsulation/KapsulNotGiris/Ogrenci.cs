using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsulNotGiris
{
    internal class Ogrenci
    {
        public Ogrenci() 
        {
            not1 = 55;
            not2 = 60;
            not3 = 70;

        }
        int ogrNo;
        string ogrName;
        string ogrSurname;

        double not1;
        double not2;
        double not3;

        public int OgrNo { get => ogrNo; set => ogrNo = Math.Abs(value); }
        public string OgrName { get => ogrName; set => ogrName = value.ToUpper(); }
        public string OgrSurname { get => ogrSurname; set => ogrSurname = value.ToUpper(); }

        public double Not1 { get => not1; 
            set {
                if(value < 0)
                {
                    not1 = 0;
                }
                else if(value > 100)
                {
                    not1 = 100;
                }
                else
                {
                    not1 = value;
                }
            } 
        }
        public double Not2 { get => not2; set
            {
                if (value < 0)
                {
                    not2 = 0;
                }
                else if (value > 100)
                {
                    not2 = 100;
                }
                else
                {
                    not2 = value;
                }
            }
        }
        public double Not3 { get => not3; set
            {
                if (value < 0)
                {
                    not3 = 0;
                }
                else if (value > 100)
                {
                    not3 = 100;
                }
                else
                {
                    not3 = value;
                }
            }
        }

        public double OrtalamaHesap()
        {
            return (not1 + not2 + not3) / 3;
        }

        public double Ortalama { get { return OrtalamaHesap(); } } //read only
    }
}
