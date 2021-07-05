using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Daire
    {

        public double yaricap { get; set; }
        

        public double CevreHesapla()
        {
            return Math.PI * yaricap;
        }
        public double AlanHesapla()
        {
          
            return  Math.PI * Math.Pow(yaricap, 2);
        }
    }
}
