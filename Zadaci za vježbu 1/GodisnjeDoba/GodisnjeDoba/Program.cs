using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodisnjeDoba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Datum (dd mmmm): ");
            string unos = Console.ReadLine();
            string[] datum = unos.Split(' ');

            int dan = Convert.ToInt32(datum[0]);
            string mjesec = datum[1];

            string doba = "";

            if (mjesec == "siječanj" || mjesec == "veljača") doba = "zima";
            else if (mjesec == "travanj" || mjesec == "svibanj") doba = "proljeće";
            else if (mjesec == "srpanj" || mjesec == "kolovoz") doba = "ljeto";
            else if (mjesec == "listopad" || mjesec == "studeni") doba = "jesen";
            else if (mjesec == "ožujak")
            {
                if (dan < 21) doba = "zima";
                else doba = "proljeće";
            }
            else if (mjesec == "lipanj")
            {
                if (dan < 21) doba = "proljeće";
                else doba = "ljeto";
            }
            else if (mjesec == "rujan")
            {
                if (dan < 23) doba = "ljeto";
                else doba = "jesen";
            }
            else if (mjesec == "prosinac")
            {
                if (dan < 21) doba = "jesen";
                else doba = "zima";
            }

            Console.WriteLine("Godišnje doba: "+doba);
            Console.ReadLine();
        }
    }
}
