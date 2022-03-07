using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("C = ");
            int c = Convert.ToInt32(Console.ReadLine());

            int suma=0;
            int zastavicaPrvi = 0;
            Console.Write("Rezultat je ");
            for(int i = a; i <= b; i++)
            {
                if (i % c == 0)
                {
                    if (zastavicaPrvi==0) Console.Write(i);
                    else Console.Write(", " + i);
                    suma += i;
                    zastavicaPrvi++;
                }
            }
            Console.WriteLine("\nSuma je "+suma);

            Console.ReadLine();
        }
    }
}
