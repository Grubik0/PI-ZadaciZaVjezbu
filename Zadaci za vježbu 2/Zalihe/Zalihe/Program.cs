using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Skladiste skladiste = new Skladiste();
            int izbor = 100;
            string naziv = "";
            int kolicina = 0;

            do {
                Console.WriteLine("1. Dodaj proizvod na skladište");
                Console.WriteLine("2. Povećaj količinu proizvoda");
                Console.WriteLine("3. Smanji količinu proizvoda");
                Console.WriteLine("4. Ispis stanja skladišta");
                Console.WriteLine("0. Izlaz");
                izbor = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (izbor == 1)
                {
                    Console.Write("Naziv: ");
                    naziv = Console.ReadLine();
                    Console.Write("Jedinična cijena: ");
                    double jedC = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Stanje: ");
                    int st = Convert.ToInt32(Console.ReadLine());
                    Proizvod proizvod = new Proizvod(naziv, jedC, st);
                    skladiste.DodajProizvod(proizvod);
                }
                else if (izbor == 2)
                {
                    Console.Write("Naziv: ");
                    naziv = Console.ReadLine();
                    Console.Write("Količina za dodati: ");
                    kolicina = Convert.ToInt32(Console.ReadLine());
                    Proizvod proizvod2 = skladiste.DohvatiProizvod(naziv);
                    proizvod2.DodajNaStanje(kolicina);
                }
                else if (izbor == 3)
                {
                    Console.Write("Naziv: ");
                    naziv = Console.ReadLine();
                    Console.Write("Količina za oduzeti: ");
                    kolicina = Convert.ToInt32(Console.ReadLine());
                    Proizvod proizvod3 = skladiste.DohvatiProizvod(naziv);
                    proizvod3.OduzmiSaStanja(kolicina);
                }
                else if (izbor == 4)
                {
                    List<Proizvod> proizvodi = skladiste.DohvatiSveProizvode();
                    foreach(Proizvod item in proizvodi)
                        Console.WriteLine("{0} {1} {2}",item.naziv, item.jedCijena, item.stanje, item.jedCijena*item.stanje);
                    Console.WriteLine("UKUPNO: "+ skladiste.IzracunajVrijednostZaliha()); 
                    
                }
            } while (izbor != 0);
        }
    }
}
