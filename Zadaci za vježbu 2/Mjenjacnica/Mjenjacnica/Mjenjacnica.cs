using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Mjenjacnica
    {
        public TecajnaLista lista = new TecajnaLista();

        public Potvrda PromijeniNovac(double hrk, string valuta)
        {
            double tecaj = 0;
            foreach(Tecaj item in lista.tecajnaL)
                if(valuta == item.valuta)
                {
                    tecaj = item.tecaj;
                    break;
                }
            double iznos = KonverterValuta.Konvertiraj(hrk, tecaj);


            Potvrda potvrda = new Potvrda(hrk, tecaj, iznos);
            return potvrda;
        }

        public void IspisPotvrde(double hrk, string valuta)
        {
            Potvrda potvrda = PromijeniNovac(hrk, valuta);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Datum: "+potvrda.datum);
            Console.WriteLine("Iznos za promjenu: "+potvrda.promjena+" HRK");
            Console.WriteLine("Po tečaju: "+potvrda.tecaj);
            Console.WriteLine("Iznosi: "+potvrda.iznos);
            Console.WriteLine("Naknada: 5% ({0} EUR)",potvrda.naknada);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Za isplatitit: "+potvrda.isplata+" EUR");
        }
    }
}
