using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    internal class Proizvod
    {
        public string naziv;
        public double jedCijena;
        public int stanje;

        public Proizvod(string aNaziv, double aJedCijena, int aStanje)
        {
            naziv = aNaziv;
            jedCijena = aJedCijena;
            stanje = aStanje;
        }

        public void DodajNaStanje(int kol)
        {
            stanje += kol;
        }

        public void OduzmiSaStanja(int kol)
        {
            stanje -= kol;
        }
    }
}
