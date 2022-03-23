using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobusnaKarta
{
    internal class AutobusniKolodvor
    {
        private List<Linija> linije = new List<Linija>();
        
        public AutobusniKolodvor()
        {
            linije.Add(new Linija("Varazdin;Zagreb;80"));
            linije.Add(new Linija("Varazdin;Cakovec;20"));
            linije.Add(new Linija("Varazdin;Slavonski Brod;240"));
            linije.Add(new Linija("Varazdin;Krapina;40"));
            linije.Add(new Linija("Varazdin;Novi Marof;22"));
            linije.Add(new Linija("Varazdin;Koprivnica;45"));
            linije.Add(new Linija("Varazdin;Virovitica;100"));
            linije.Add(new Linija("Varazdin;Osijek;220"));
        }

        public double IzracunajCijenu(int udaljenost, string tipKarte)
        {
            if (tipKarte == "Regularna") return udaljenost * 1.5;
            else if (tipKarte == "Studentska") return udaljenost * 1.2;
            else return udaljenost * 2;
        }

        public void KupiKartu(string polaziste, string odrediste, string tipKarte)
        {
            int udaljenost = 0;
            for(int i = 0; i < 8; i++)
            {
                if ((linije[i].Polaziste == polaziste && linije[i].Odrediste == odrediste) || (linije[i].Polaziste == odrediste && linije[i].Odrediste == polaziste))
                {
                    udaljenost = linije[i].Udaljenost;
                    break;
                }
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Cijena za kartu tipa {0}, na relaciji {1} - {2} iznosi {3} kn!",tipKarte,polaziste,odrediste,IzracunajCijenu(udaljenost,tipKarte));
        }

    }
}
