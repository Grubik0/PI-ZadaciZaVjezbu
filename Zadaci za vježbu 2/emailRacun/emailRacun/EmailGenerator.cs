using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emailRacun
{
    internal class EmailGenerator
    {
        public static string GenerirajEmail (string ime, string prezime)
        {
            return (ime + "."+ prezime + "@foi.hr").ToLower();
        }

        public static string GenerirajSkraceniEmail (string ime, string prezime)
        {
            return (ime[0] + prezime.Substring(0, 5) + "@foi.hr").ToLower();
        }

    }
}
