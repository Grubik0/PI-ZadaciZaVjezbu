using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovneTransakcije
{
    internal class Banka
    {
        private List<Racun> Racuni = new List<Racun> ();

        public Banka() {
            Racuni.Add(new Racun("HR11",100000));
            Racuni.Add(new Racun("HR22", 50000));
            Racuni.Add(new Racun("HR33", 12000));
            Racuni.Add(new Racun("HR44", 36000));
        }

        private Racun DohvatiRacun(string iban)
        {
            int j = 0;
            for(int i = 0; i<4; i++)
            {
                if (iban == Racuni[i].iban) {
                    j = i;
                    break;
                }
            }
            return Racuni[j];

        }

        public Transakcija IzvrsiPlacanje(string ibanPlatitelja, string ibanPrimatelja, double iznos)
        {
            Transakcija trans = new Transakcija();
            trans.platitelj = DohvatiRacun(ibanPlatitelja);
            trans.platitelj.stanje -= iznos;
            trans.primatelj = DohvatiRacun(ibanPrimatelja);
            trans.primatelj.stanje += iznos; 
            trans.iznos = iznos;

            return trans;
        }
    }
}
