using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskeSobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            string naredba = "";
            string[] ulaz = new string[2];
            List<Soba> sobe = new List<Soba>();
            while (naredba != "#exit")
            {
                Console.Write("Unesite naredbu: ");
                naredba = Console.ReadLine();
                if (naredba != "#exit")
                {
                    ulaz = naredba.Split(' ');
                    if(ulaz[0] == "#pronadji")
                    {
                        sobe = hotel.PronadjiSobe(Convert.ToInt32(ulaz[1]));
                        foreach(Soba item in sobe)
                            Console.WriteLine("Oznaka: {0}, Kapacitet: {1}",item.Oznaka, item.Kapacitet);
                    }
                    else if(ulaz[0] == "#rezerviraj")
                    {
                        hotel.RezervirajSobu(ulaz[1]);
                    }
                    Console.WriteLine("-----------------------------------");
                }

            }
        }
    }
}
