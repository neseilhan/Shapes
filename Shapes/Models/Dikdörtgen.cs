using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Dikdörtgen : IDortgen
    {
        public double UzunKenar { get; set; }
        public double KısaKenar { get; set; }

        public double AlanHesapla()
        {
            return UzunKenar * KısaKenar;
        }
        public double CevreHesapla()
        {
            return (UzunKenar + KısaKenar) * 2;
        }
    }
}
