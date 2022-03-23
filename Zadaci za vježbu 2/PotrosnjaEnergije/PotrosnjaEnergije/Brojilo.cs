using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosnjaEnergije
{
    internal class Brojilo
    {
        public enum TipBrojila { voda,struja,plin}

        public string naziv { get; set; }
        public TipBrojila tip { get; set; }
        private double stanje;
        private double zadnjeOcitanje;

        public Brojilo(string aNaziv, TipBrojila aTip, double aStanje, double aZadnjeOcitanje)
        {
            naziv = aNaziv;
            tip = aTip;
            stanje = aStanje;
            zadnjeOcitanje = aZadnjeOcitanje;
        }

        public double OcitajPotrosnju()
        {
            return stanje - zadnjeOcitanje;
        }
       
    }
}
