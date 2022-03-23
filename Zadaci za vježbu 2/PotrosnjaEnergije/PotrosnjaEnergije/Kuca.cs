using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosnjaEnergije
{
    internal class Kuca
    {
        public List<Brojilo> brojila = new List<Brojilo>();

        public Kuca()
        {
            brojila.Add(new Brojilo("HEP_101", Brojilo.TipBrojila.struja, 34235, 32150));
            brojila.Add(new Brojilo("TP_222", Brojilo.TipBrojila.plin, 11500, 10400));
            brojila.Add(new Brojilo("VAR_123", Brojilo.TipBrojila.voda, 16225, 16100));
        }

        private double DohvatiCijenuEnergenata(Brojilo.TipBrojila tip)
        {
            if (tip == Brojilo.TipBrojila.voda) return 3.5;
            else if (tip == Brojilo.TipBrojila.struja) return 0.1;
            else return 0.2;
        }

        public double IzracunajIznosZaBrojilo (Brojilo brojilo)
        {
            return (brojilo.OcitajPotrosnju()) * DohvatiCijenuEnergenata(brojilo.tip);
        }

        public double IzracunajIznosUkupno()
        {
            double suma = 0;
            foreach (Brojilo item in brojila)
                suma += IzracunajIznosZaBrojilo(item);
            return suma;
        }

    }
}
