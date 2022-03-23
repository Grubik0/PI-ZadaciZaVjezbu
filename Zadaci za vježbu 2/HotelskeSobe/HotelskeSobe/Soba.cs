using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskeSobe
{
    internal class Soba
    {
        public enum StatusSobe {slobodno, rezervirano};
        public string Oznaka;
        public int Kapacitet;
        public StatusSobe Status;

        public Soba(string aOznaka,int aKap, StatusSobe aStatus)
        {
            Oznaka = aOznaka;
            Kapacitet = aKap;
            Status = aStatus;
        }
    }
}
