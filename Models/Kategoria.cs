using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_API.Models
{
    public class Kategoria
    {
        public Kategoria()
        {
            Pokoj = new HashSet<Pokoj>();
        }

        public int IdKategoria { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
        public virtual ICollection<Pokoj> Pokoj { get; set; }
    }
}
