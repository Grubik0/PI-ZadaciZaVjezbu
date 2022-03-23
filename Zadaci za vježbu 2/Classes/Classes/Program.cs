using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Luka","G");
            Student student1 = new Student(5);

            osoba1.ispis();
            student1.ispis();

            Console.ReadLine();
        }
    }
}
