using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int izbor = 0;
            do
            {
                Prvenstvo prvenstvo = new Prvenstvo();

                Console.WriteLine("PRVENSTVO APP");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Unesi reprezentaciju");
                Console.WriteLine("2. Evidentiraj utakmicu");
                Console.WriteLine("3. Ispiši rezultate");
                Console.WriteLine("4. Ispiši tablicu");
                Console.WriteLine("0. Izlaz");
                izbor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------------");
                Console.Clear();

                if(izbor != 0)
                {
                    Console.Write("Oznaka reprezentacije: ");
                    string oznaka = Console.ReadLine();
                    Console.Write("Naziv reprezentacije: ");
                    string naziv = Console.ReadLine();
                    prvenstvo.DodajRep(oznaka, naziv);
                    prvenstvo.IspisRep();
                  
                }
            } while (izbor != 0);
        }
    }
}
