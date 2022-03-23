using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mjenjacnica mjenjacnica = new Mjenjacnica();

            Console.Write("Iznos HRK: ");
            double hrk = Convert.ToDouble(Console.ReadLine());
            Console.Write("Odredišna valuta: ");
            string valuta = Console.ReadLine();

            mjenjacnica.IspisPotvrde(hrk, valuta);

            Console.ReadLine();

        }
    }
}
