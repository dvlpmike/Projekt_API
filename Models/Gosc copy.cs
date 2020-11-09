using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_API.Models
{
    public class Gosc
    {
        public Gosc()
        {
            Rezerwacja = new HashSet<Rezerwacja>();
        }

        public int IdGosc { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int? ProcentRabatu { get; set; }

        public virtual ICollection<Rezerwacja> Rezerwacja { get; set; }
    }
}
