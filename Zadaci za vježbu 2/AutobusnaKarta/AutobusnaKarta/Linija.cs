using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobusnaKarta
{
    internal class Linija
    {
        public string Polaziste;
        public string Odrediste;
        public int Udaljenost;

        public Linija(string ulaz)
        {
            string[] ulazA = new string[3];
            ulazA = ulaz.Split(';');
            Polaziste = ulazA[0];
            Odrediste = ulazA[1];
            Udaljenost = Convert.ToInt32(ulazA[2]);
        }
    }
}
