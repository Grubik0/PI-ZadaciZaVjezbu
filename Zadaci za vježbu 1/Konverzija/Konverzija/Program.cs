using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverzija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string [10]{"nula", "jedan", "dva", "tri", "četri", "pet", "šest", "sedam", "osam", "devet" };

            Console.Write("Iznos: ");
            string unos = Console.ReadLine();
            string[] brojevi = unos.Split(' ');
            int broj = 0;
            int suma = 0;
            int x = 1;
            int n = brojevi.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                    if (brojevi[i] == lista[j]) broj = j;
                if(broj == 0 && i == 0)
                {
                    suma = suma + (1 * x);
                }
                suma = suma + (broj * x);
                x = x * 10;
            }

            Console.Write("Tecaj: ");
            double tecaj = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} KN po tecaju {1} iznosi {2} EUR", suma, tecaj, suma/tecaj);


            Console.ReadLine();
        }
    }
}
