using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj jedinica: ");
            int jedinice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite broj desetica: ");
            int desetice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rezultat: " + ((desetice * 10) + jedinice) * 2.1);
            Console.ReadLine();
        }
    }
}
