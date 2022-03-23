using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Potvrda
    {
        public DateTime datum;
        public double promjena;
        public double tecaj;
        public double iznos;
        public double naknada;
        public double isplata;

        public Potvrda(double aPromjena, double aTecaj, double aIznos)
        {
            datum = DateTime.Now;
            promjena = aPromjena;
            tecaj = aTecaj;
            iznos = aIznos;
            naknada = iznos * 0.05;
            isplata = iznos - naknada;
        }
    }
}
