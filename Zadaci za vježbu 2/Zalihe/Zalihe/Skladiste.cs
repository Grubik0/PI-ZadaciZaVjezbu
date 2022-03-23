using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe
{
    internal class Skladiste
    {
        private List<Proizvod> proizvodi = new List<Proizvod>();

        public void DodajProizvod(Proizvod proizvod)
        {
            bool f = true;
            foreach(Proizvod item in proizvodi)
            {
                if(item.naziv == proizvod.naziv)
                {
                    f = false;
                    break;
                }
            }

            if (f)
            {
                proizvodi.Add(proizvod);
                Console.WriteLine("Proizvod dodan!");
            }
            else Console.WriteLine("Proizvod već postoji!");
            Console.ReadLine();
        }

        public Proizvod DohvatiProizvod(string naziv)
        {
            foreach(Proizvod item in proizvodi)
            {
                if (item.naziv == naziv) return item;
                
            }
            return null;
        }

        public List<Proizvod> DohvatiSveProizvode()
        {
            List<Proizvod> proizvodiL = new List<Proizvod>();
            foreach (Proizvod item in proizvodi) proizvodiL.Add(item);
            return proizvodiL;
        }

        public void UkloniProizvod(Proizvod proizvod)
        {
            proizvodi.Remove(proizvod);
        }

        public double IzracunajVrijednostZaliha()
        {
            double suma = 0;
            foreach (Proizvod item in proizvodi) suma += (item.jedCijena * item.stanje);
            return suma;
        }
    }
}
