using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovneTransakcije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banka banka = new Banka();
            string platitelj, primatelj;
            double iznos;
            Console.Write("IBAN platitelja: ");
            platitelj=Console.ReadLine();
            Console.Write("IBAN primatelja: ");
            primatelj = Console.ReadLine();
            Console.Write("Iznos: ");
            iznos = Convert.ToDouble(Console.ReadLine());
            Transakcija transakcija = banka.IzvrsiPlacanje(platitelj, primatelj, iznos);

            Console.WriteLine();
            Console.WriteLine("POTVRDA TRANSAKCIJE:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Novo stanje računa {0} je {1}",transakcija.platitelj.iban,transakcija.platitelj.stanje);
            Console.WriteLine("Novo stanje računa {0} je {1}", transakcija.primatelj.iban,transakcija.primatelj.stanje);


            Console.ReadLine();
        }
    }
}
