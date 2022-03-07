using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonetskaAbeceda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite riječ: ");
            string unos = Console.ReadLine().ToUpper();
            string fonetsko = "";
            string pom = "";
            int n = unos.Length;
            for (int i = 0; i < n; i++)
            {
                if (unos[i] == 'A') pom = "Alfa";
                else if (unos[i] == 'B') pom = "Bravo";
                else if (unos[i] == 'C') pom = "Charlie";
                else if (unos[i] == 'D') pom = "Delta";
                else if (unos[i] == 'E') pom = "Echo";
                else if (unos[i] == 'F') pom = "Foxtrot";
                else if (unos[i] == 'G') pom = "Golf";
                else if (unos[i] == 'H') pom = "Hotel";
                else if (unos[i] == 'I') pom = "India";
                else if (unos[i] == 'J') pom = "Juliett";
                else if (unos[i] == 'K') pom = "Kilo";
                else if (unos[i] == 'L') pom = "Lima";
                else if (unos[i] == 'M') pom = "Mike";
                else if (unos[i] == 'N') pom = "November";
                else if (unos[i] == 'O') pom = "Oscar";
                else if (unos[i] == 'P') pom = "Papa";
                else if (unos[i] == 'Q') pom = "Quebec";
                else if (unos[i] == 'R') pom = "Romeo";
                else if (unos[i] == 'S') pom = "Sierra";
                else if (unos[i] == 'T') pom = "Tango";
                else if (unos[i] == 'U') pom = "Uniform";
                else if (unos[i] == 'V') pom = "Victor";
                else if (unos[i] == 'W') pom = "Whiskey";
                else if (unos[i] == 'X') pom = "Xray";
                else if (unos[i] == 'Y') pom = "Yankee";
                else if (unos[i] == 'Z') pom = "Zulu";
                else if (unos[i] == ' ') pom = "|";

                fonetsko += pom + " ";
            }
            Console.WriteLine("Riječ u fonetskome: " + fonetsko);
            Console.ReadLine();
        }
    }
}
