using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskeSobe
{
    internal class Hotel
    {
        private List<Soba> sobe = new List<Soba>();

        public Hotel()
        {
            sobe.Add(new Soba("10A", 3, Soba.StatusSobe.slobodno));
            sobe.Add(new Soba("10B", 1, Soba.StatusSobe.rezervirano));
            sobe.Add(new Soba("11A", 2, Soba.StatusSobe.slobodno));
            sobe.Add(new Soba("11B", 4, Soba.StatusSobe.slobodno));
            sobe.Add(new Soba("12A", 5, Soba.StatusSobe.slobodno));
            sobe.Add(new Soba("12B", 3, Soba.StatusSobe.rezervirano));
            sobe.Add(new Soba("13A", 1, Soba.StatusSobe.slobodno));
            sobe.Add(new Soba("13A", 2, Soba.StatusSobe.rezervirano));
        }

        public List<Soba> PronadjiSobe(int br)
        {
            List<Soba> slSobe = new List<Soba>();
            for(int i = 0; i < sobe.Count; i++)
            {
                if (sobe[i].Status == Soba.StatusSobe.slobodno && sobe[i].Kapacitet >= br) slSobe.Add(sobe[i]);
            }

            return slSobe;
        }

        public void RezervirajSobu(string oznaka)
        {
            for (int i = 0; i < sobe.Count; i++)
            {
                if (sobe[i].Oznaka == oznaka)
                {
                    if (sobe[i].Status == Soba.StatusSobe.slobodno)
                    {
                        sobe[i].Status = Soba.StatusSobe.rezervirano;
                        Console.WriteLine("Soba {0} rezervirana!", oznaka);
                        break;
                    }
                    else Console.WriteLine("Soba {0} je zauzeta!", oznaka);
                }

            }
        }
    }
}
