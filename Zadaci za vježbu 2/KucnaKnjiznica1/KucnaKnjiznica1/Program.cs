using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knjiznica knjiznica = new Knjiznica();

            Console.WriteLine("ISBN knjige: ");
            string isbn = Console.ReadLine();
            Console.WriteLine("--------------------------------------");

            knjiznica.Posudi(isbn);

            Console.ReadLine();
        }
    }
}
