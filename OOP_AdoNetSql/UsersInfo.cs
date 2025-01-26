using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ADO.NET_SQL
{
    public class UsersInfo
    {
        private string pKSifre;
        private string kgKadi;
        private string kgSifre;
        private string pKAdSoyad;
        private string pKKadi;

        public string KGKadi { get => kgKadi; set => kgKadi = value; }
        public string KGSifre { get => kgSifre; set => kgSifre = value; }
        public string PKAdSoyad { get => pKAdSoyad; set => pKAdSoyad = value; }
        public string PKKadi { get => pKKadi; set => pKKadi = value; }
        public string PKSifre { get => pKSifre; set => pKSifre = value; }
    }
}
