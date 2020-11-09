using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_API.Models
{
    public class Pokoj
    {
        public Pokoj()
        {
            Rezerwacja = new HashSet<Rezerwacja>();
        }

        public int NrPokoju { get; set; }
        public int IdKategoria { get; set; }
        public int LiczbaMiejsc { get; set; }
        public virtual Kategoria IdKategoriaNavigation { get; set; }
    }
}
