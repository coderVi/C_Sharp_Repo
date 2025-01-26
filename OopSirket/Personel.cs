using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSirketOdev
{
    internal abstract class Personel
    {
        private string _name, _surName;

        public string Name { get => _name; set => _name = char.ToUpper(value[0]) + value.Substring(1).ToLower(); }
        public string SurName { get => _surName; set => _surName = value.ToUpper(); }
        public abstract double KHesap(int kSayi, int  tecrübe );
    }

    internal class Yönetici : Personel
    {
        public override double KHesap(int kSayi, int tecrübe)
        {
            double maasPuan = 1500; 
            double zamOrani = 0.02; 
            double maas = maasPuan * kSayi; 
            for (int i = 0; i < tecrübe; i++) { maas += maas * zamOrani; } 
            return maas;
        }
    }

    internal class Ogretmen : Personel
    {
        public override double KHesap(int kSayi, int tecrübe)
        {
            double maasPuan = 800;
            double zamOrani = 0.02;
            double maas = maasPuan * kSayi;
            for (int i = 0; i < tecrübe; i++) { maas += maas * zamOrani; }
            return maas;
        }
    }

    internal class Calisan : Personel
    {
        public override double KHesap(int kSayi, int tecrübe)
        {
            double maasPuan = 400;
            double zamOrani = 0.02;
            double maas = maasPuan * kSayi;
            for (int i = 0; i < tecrübe; i++) { maas += maas * zamOrani; }
            return maas;
        }
    }
}
