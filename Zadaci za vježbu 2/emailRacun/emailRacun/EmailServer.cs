using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emailRacun
{
    internal class EmailServer
    {
        public static KorisnickiRacun KreirajKorisnickiRacun (string ime, string prezime)
        {
            KorisnickiRacun korisnickiRacun = new KorisnickiRacun(ime, prezime, EmailGenerator.GenerirajEmail(ime, prezime), EmailGenerator.GenerirajSkraceniEmail(ime, prezime), LozinkaGenerator.GenerirajLozinku(ime, prezime));
            return korisnickiRacun;
        }
    }
}
