using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X= ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y= ");
            int y = Convert.ToInt32(Console.ReadLine());

            double rezultat = 1;

            if (y < 0) {
                y = 0 - y;
                x = 1 / x;
            }

            for(int i = 0; i<y; i++)
            {
                if (y == 0) rezultat = 1;
                else if (y > 0)
                {
                    if (i == y - 1) Console.Write(x);
                    else Console.Write(x + "*");
                    rezultat *= x;
                }
            }

            Console.Write("="+rezultat);

            Console.ReadLine();
            
        }
    }
}
