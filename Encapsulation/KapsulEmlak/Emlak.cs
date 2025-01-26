using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsulEmlak
{
    internal class Emlak
    {
        string semt; //Defaul private
        int odaSayisi;
        int katNo;
        int alan;

        public string Semt { get => semt; set => semt = value.ToUpper(); }
        public int OdaSayisi { get => odaSayisi;
            set
            {
                if (value <= 8 && value > 0)
                {
                    odaSayisi = value;
                }
                else if (value >= 8)
                {
                    odaSayisi = 8;

                }
                else { odaSayisi = 1; }
            }

        }
        public int KatNo { get => katNo; set => katNo = Math.Abs(value); }
        public int Alan { get => alan; set => alan = Math.Abs(value); }
    }
}
