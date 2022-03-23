using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Student : Osoba
    {
        protected int ects;

        public Student(int aEcts) : base(Console.ReadLine(), Console.ReadLine())
        {
            ects = aEcts;
        }

        public override void ispis()
        {
            Console.WriteLine("Ime: " + ime);
            Console.WriteLine("Prezime: " + prezime);
            Console.WriteLine("ECTS: "+ ects);
        }
    }
}
