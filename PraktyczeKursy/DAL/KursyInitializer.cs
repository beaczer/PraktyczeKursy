using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using PraktyczeKursy.DAL;
using PraktyczeKursy.Migrations;
using PraktyczeKursy.Models;

namespace PraktyczneKursy.DAL
{
    public class KursyInitializer : MigrateDatabaseToLatestVersion<KursyContext, Configuration>
    {
        public static void SeedKursyData(KursyContext context)
        {
            var Kategorie = new List<Kategoria>
                {
                new Kategoria() { KategoriaId = 1, NazwaKategorii = "asp", NazwaPlikuIkony = "1.png", OpisKategori = "opis1" },
                new Kategoria() { KategoriaId = 2, NazwaKategorii = "java", NazwaPlikuIkony = "2.png", OpisKategori = "opis1" },
                new Kategoria() { KategoriaId = 3, NazwaKategorii = "c", NazwaPlikuIkony = "3.png", OpisKategori = "opis1" },
                new Kategoria() { KategoriaId = 4, NazwaKategorii = "c++", NazwaPlikuIkony = "4.png", OpisKategori = "opis1" },
                new Kategoria() { KategoriaId = 1, NazwaKategorii = "c#", NazwaPlikuIkony = "5.png", OpisKategori = "opis1" }
            };
            Kategorie.ForEach(x => context.Kategorie.AddOrUpdate(x));
            context.SaveChanges();

            var kursy = new List<Kurs>
            {
                new Kurs(){ AutorKursu="Adam", Bestseller=true, CenaKursu=100, DataDodania=DateTime.Now,
                            KategoriaId=1, KursId=1, NazwaPlikuObr="1.png", OpisKursu="asp", TytulKursu="kurs1", Ukryty=false
                },
                new Kurs(){ AutorKursu="Jan", Bestseller=true, CenaKursu=120, DataDodania=DateTime.Now,
                            KategoriaId=1, KursId=1, NazwaPlikuObr="1.png", OpisKursu="asp", TytulKursu="kurs1", Ukryty=false
                },
                new Kurs(){ AutorKursu="Adrian", Bestseller=false, CenaKursu=100, DataDodania=DateTime.Now,
                            KategoriaId=1, KursId=1, NazwaPlikuObr="1.png", OpisKursu="asp", TytulKursu="kurs1", Ukryty=false
                },
                new Kurs(){ AutorKursu="Jozef", Bestseller=true, CenaKursu=75, DataDodania=DateTime.Now,
                            KategoriaId=1, KursId=1, NazwaPlikuObr="1.png", OpisKursu="asp", TytulKursu="kurs1", Ukryty=false
                }
            };
            kursy.ForEach(x => context.Kursy.AddOrUpdate(x));
            context.SaveChanges();
            }
        }
    }
