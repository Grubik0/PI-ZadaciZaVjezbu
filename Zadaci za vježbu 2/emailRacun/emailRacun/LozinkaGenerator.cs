using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emailRacun
{
    internal class LozinkaGenerator
    {
        public static string GenerirajLozinku(string ime, string prezime)
        {
            return (prezime + Convert.ToString(ime.Length + prezime.Length)).ToLower();
        }
    }
}
