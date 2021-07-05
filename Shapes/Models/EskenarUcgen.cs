using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class EskenarUcgen : IUcgen

    {
        public double Kenar { get; set; }

        public double AlanHesapla()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(Kenar, 2);
        }


        public double CevreHesapla()
        {
            return Kenar * 3;
        }
    }
}
