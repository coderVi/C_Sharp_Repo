using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ADO.NET_SQL
{
    public class DbConnetionString
    {
        string _connetion = "Server=DESKTOP-PDRSFJK\\SQLEXPRESS;Database=KutuphaneOopAdoDB;Trusted_Connection=True;";

        public string Connetion { get => _connetion; }
    }
}
