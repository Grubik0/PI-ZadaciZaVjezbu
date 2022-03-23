using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobusnaKarta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutobusniKolodvor kolodvor = new AutobusniKolodvor();
            string[] ulaz = new string[3];
            Console.WriteLine("Unesite polaziste, odrediste i tip karte:");
            ulaz = (Console.ReadLine()).Split(' ');

            kolodvor.KupiKartu(ulaz[0], ulaz[1], ulaz[2]);

            Console.ReadLine();
        }
    }
}
