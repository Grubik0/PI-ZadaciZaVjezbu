using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Prvenstvo
    {
        public List<Reprezentacija> repL = new List<Reprezentacija>();

        public void DodajRep(string oznaka, string naziv)
        {
            
            repL.Add(new Reprezentacija(oznaka, naziv));
        }
        public void IspisRep()
        {
            Console.WriteLine(repL.Count);
        }
    }
}
