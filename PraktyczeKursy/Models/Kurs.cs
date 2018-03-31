using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PraktyczeKursy.Models
{
    public class Kurs
    {

        public int KursId { get; set; }
        public int KategoriaId { get; set; }
        [Required(ErrorMessage="Nalezy podac tytul")]
        [StringLength(100)]
        public string TytulKursu { get; set; }
        [Required(ErrorMessage ="Wprowadz autora")]
        [StringLength(100)]
        public string AutorKursu { get; set; }
        public DateTime DataDodania { get; set; }
        public string NazwaPlikuObr { get; set; }
        public string OpisKursu { get; set; }
        public decimal CenaKursu { get; set; }
        public bool Bestseller { get; set; }
        public bool Ukryty { get; set; }
        public string OpisSkrocony { get; set; }

        public virtual Kategoria Kategoria { get; set; }
    }
}