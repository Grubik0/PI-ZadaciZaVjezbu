using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    internal class TecajnaLista
    {
        public List<Tecaj> tecajnaL = new List<Tecaj>();

        public TecajnaLista()
        {
            tecajnaL.Add(new Tecaj("EUR", 7.5));
            tecajnaL.Add(new Tecaj("USD", 6.9));
            tecajnaL.Add(new Tecaj("CHF", 7.3));
        }
    }
}
