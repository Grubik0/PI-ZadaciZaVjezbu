using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzbornikSortiranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int izbor = 100;
            List<string> gradovi = new List<string>();
            do {
                Console.WriteLine("1. Unos");
                Console.WriteLine("2. Sortiranje");
                Console.WriteLine("3. Ispis");
                Console.WriteLine("0. Izlaz");
                Console.Write("Izbor: ");

                izbor = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (izbor)
                {
                    case 1:
                        Console.Write("Grad: ");
                        gradovi.Add(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Uzlazno (u) ili silazno (s)?: ");
                        string sortiranje = Console.ReadLine();
                        if (sortiranje == "u") gradovi.Sort();
                        else
                        {
                            gradovi.Sort();
                            gradovi.Reverse();
                        }
                        break;

                    case 3:
                        int n = gradovi.Count();
                        for (int i = 0; i < n; i++)
                            Console.WriteLine(gradovi[i]);
                        Console.ReadLine();
                        break;

                }
                Console.Clear();

                
            } while (izbor != 0);
        }
    }
}
