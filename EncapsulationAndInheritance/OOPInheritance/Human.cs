using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    internal class Human //BaseClass - Main Class - Super Class
    {
        string _name, _surname;
        int _kilo , _age;
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set { value.ToUpper(); } }
        public int Age { get { return _age; } set 
            {
                if(value < 0) value = 0;
                else if(value > 0 && value <= 100) _age = value;
            } }
        public int Kilo { get => _kilo; set => _kilo = Math.Abs(value); }
    }
}
