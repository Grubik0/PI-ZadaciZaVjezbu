using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovneTransakcije
{
    internal class Racun
    {
        public string iban;
        public double stanje;

        public Racun(string aIban, double aStanje)
        {
            iban = aIban;
            stanje = aStanje;
        }
    }
}
