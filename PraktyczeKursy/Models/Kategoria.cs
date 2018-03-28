using System.Collections;
using System.Collections.Generic;

namespace PraktyczeKursy.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        public string NazwaKategorii { get; set; }
        public string OpisKategori { get; set; }
        public string NazwaPlikuIkony{ get; set; }

        public virtual ICollection<Kurs> Kursy { get; set; }
    }
}