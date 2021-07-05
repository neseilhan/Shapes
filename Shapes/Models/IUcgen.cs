using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    interface IUcgen
    {
        double Kenar { get; set; }
        double AlanHesapla();
        double CevreHesapla();
    }
}
