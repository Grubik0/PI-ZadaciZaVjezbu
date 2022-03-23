using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Tecaj
    {
        public string valuta;
        public double tecaj;

        public Tecaj(string aVal, double aTecaj)
        {
            valuta = aVal;
            tecaj = aTecaj;
        }
    }
}
