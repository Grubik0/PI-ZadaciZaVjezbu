using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class GlasackaKutija
    {
        private List<Glas> glasovi = new List<Glas>();

        public bool VecGlasao(string oib)
        {
            for (int i = 0; i < glasovi.Count; i++)
                if (glasovi[i].oib == oib) return true;
            return false;
        }

        public void Glasaj(string oib, string odabir)
        {
            if (VecGlasao(oib) == false)
            {
                glasovi.Add(new Glas(oib, odabir));
                Console.WriteLine("Uspješno ste glasali!");
            }
            else Console.WriteLine("{0} je već glasao!", oib);
        }

        public void DohvatiRezultateGlasanja()
        {
            int za = 0, protiv = 0, susdrzan = 0;
            for(int i = 0; i<glasovi.Count; i++)
            {
                if (glasovi[i].odabir == "Z") za++;
                else if (glasovi[i].odabir == "P") protiv++;
                else susdrzan++;
            }
            Console.WriteLine("Rezultati glasanja: ZA={0}, PROTIV={1}, SUSDRZAN={2}",za,protiv,susdrzan);
            Console.WriteLine("------------------------------------");
        }
    }
}
