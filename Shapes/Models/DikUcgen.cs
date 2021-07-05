using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class DikUcgen : IUcgen
    {
        public double Kenar { get; set; }
        public double Yükseklik { get; set; }

        public double AlanHesapla()
        {
            return Kenar * Yükseklik / 2;

        }
        public double CevreHesapla()
        {
            double hipotenus = Math.Sqrt((Kenar * Kenar) + Math.Pow(Yükseklik, 2));
            return hipotenus + Kenar + Yükseklik;
        }
    }
}
