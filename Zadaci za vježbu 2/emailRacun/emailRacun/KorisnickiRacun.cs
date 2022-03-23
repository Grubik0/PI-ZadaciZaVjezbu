using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emailRacun
{
    internal class KorisnickiRacun
    {
        public string ime;
        public string prezime;
        public string email;
        public string skraceniEmail;
        public string lozinka;

        public KorisnickiRacun(string aIme, string aPrezime, string aEmail, string aSkraceniEmail, string aLozinka)
        {
            ime = aIme;
            prezime = aPrezime;
            email = aEmail;
            skraceniEmail = aSkraceniEmail;
            lozinka = aLozinka;
        }

    }
}
