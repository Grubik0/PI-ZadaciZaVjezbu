using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica1
{
    internal class Knjiga
    {
        public enum Status {dostupno, naPosudbi}
        public string isbn;
        public string naslov;
        public Status status;

        public Knjiga(string aIsbn, string aNaslov, Status aStatus)
        {
            isbn = aIsbn;
            naslov = aNaslov;
            status = aStatus;
        }

    }
}
