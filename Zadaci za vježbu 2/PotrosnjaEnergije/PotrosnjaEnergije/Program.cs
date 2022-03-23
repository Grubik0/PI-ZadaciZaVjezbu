using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosnjaEnergije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kuca kuca = new Kuca();
            Console.WriteLine("Cijena potrošene energije za prethodno razdoblje: ");
            Console.WriteLine("------------------------------------------------------");
            foreach(Brojilo item in kuca.brojila)
                Console.WriteLine("{0} ({1}) = {2} kn",item.naziv,item.tip,kuca.IzracunajIznosZaBrojilo(item));
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("UKUPNO: " + kuca.IzracunajIznosUkupno());
            Console.ReadLine();

        }
    }
}
