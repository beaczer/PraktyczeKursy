using PraktyczeKursy.Models;
using PraktyczneKursy.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PraktyczeKursy.DAL
{
    public class KursyContext:DbContext
    {
        public DbSet<Kurs> Kursy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamowienia { get; set; }
        public DbSet<Zamowienia> Zamowienia { get; set; }

        public KursyContext():base("KursyContext")
        {

        }
        static KursyContext()
        {
            

            Database.SetInitializer<KursyContext>(new KursyInitializer());
        }
        
    }
}