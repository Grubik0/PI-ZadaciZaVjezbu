using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("APLIKACIJA ZA GLASANJE");
            Console.WriteLine("------------------------------------");
            GlasackaKutija kutija = new GlasackaKutija();

            while (true)
            {
                Console.Write("Unesite OIB: ");
                string oib = Console.ReadLine();
                Console.Write("Unesite odabir (Z, P, S): ");
                string odabir = Console.ReadLine();

                kutija.Glasaj(oib, odabir);
                kutija.DohvatiRezultateGlasanja();
            }

        }
    }
}
