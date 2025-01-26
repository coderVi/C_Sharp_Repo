using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Arac
    {
        string _vitesTuru, _yakitTipi, _renk;
        int _model;

        public string VitesTuru { get => _vitesTuru; set => _vitesTuru = value; }
        public string YakitTipi { get => _yakitTipi; set => _yakitTipi = value; }
        public int Model 
        { 
            get => _model;
            set
            {
                if (value < 2010)
                {
                    throw new Exception("2010'dan eski araç girişi olamaz!");
                }
                _model = value;
            }
        }
        public string Renk { get => _renk; set => _renk = value; }
    }
    internal class Otomobil : Arac
    {
        string _otoTur;
        public string OtoTur { get => _otoTur; set => _otoTur = value; }
    }
    internal class Kamyon : Arac
    {
        int _damperKapasite, _tekerSayisi;

        public int DamperKapasite { get => _damperKapasite; set => _damperKapasite = value; }
        public int TekerSayisi { get => _tekerSayisi; set => _tekerSayisi = value; }
    }
    internal class Otobus : Arac
    {
        int _koltukSayisi;
        string _konforTipi;

        public int KoltukSayisi 
        { 
            get => _koltukSayisi;
            set
            {
                if (value < 0)
                    _koltukSayisi = 0;
                else if (value > 45)
                    throw new ArgumentException("45 den fazla Koltuk eklenemez!");
                else
                    _koltukSayisi = value;
            } 
        }
        public string KonforTipi { get => _konforTipi; set => _konforTipi = value; }
    }
    internal class IsMakinasi : Arac
    {
        string _makinaTur;
        public string MakinaTur { get => _makinaTur; set => _makinaTur = value; }
    }
    //MakinaTur→(portlift, dozer, digger – bu seçenek combobox olsun diğer seçilirse bir textbox 
    //ile kullanıcın girdiği yeni tür eklensin)
}
