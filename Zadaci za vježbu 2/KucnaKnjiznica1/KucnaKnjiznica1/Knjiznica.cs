using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica1
{
    internal class Knjiznica
    {
        private List<Knjiga> knjige = new List<Knjiga>();

        public Knjiznica()
        {
            knjige.Add(new Knjiga("1111", "Prstenova druzina", Knjiga.Status.dostupno));
            knjige.Add(new Knjiga("2222", "Dvije kule", Knjiga.Status.naPosudbi));
            knjige.Add(new Knjiga("3333", "Povratak kralja", Knjiga.Status.dostupno));
        }

        public Knjiga DohvatiKnjigu(string isbn)
        {
            foreach(Knjiga item in knjige)
            {
                if (item.isbn == isbn) return item;
            }
            Console.WriteLine("Knjiga ne postoji!");
            return null;
        }

        public void Posudi(string isbn)
        {
            Knjiga knjiga = DohvatiKnjigu(isbn);
            if (knjiga.status == Knjiga.Status.dostupno) 
            {
                knjiga.status = Knjiga.Status.naPosudbi;
                Console.WriteLine("ISBN: "+knjiga.isbn);
                Console.WriteLine("Naslov: "+knjiga.naslov);
                Console.WriteLine("Status: "+knjiga.status);
            }
            else
            {
                Console.WriteLine("Knjiga je na posudbi!");
            }
        }
    }
}
