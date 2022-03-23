using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Osoba
    {
        protected string ime;
        protected string prezime;

        public Osoba(string aIme, string aPrezime)
        {
            ime = aIme;
            prezime = aPrezime;
        }

        public virtual void ispis()
        {
            Console.WriteLine("Ime: "+ime);
            Console.WriteLine("Prezime: "+prezime);
        }
    }
}
