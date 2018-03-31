namespace PraktyczeKursy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategorias",
                c => new
                    {
                        KategoriaId = c.Int(nullable: false, identity: true),
                        NazwaKategorii = c.String(nullable: false, maxLength: 50),
                        OpisKategori = c.String(nullable: false),
                        NazwaPlikuIkony = c.String(),
                    })
                .PrimaryKey(t => t.KategoriaId);
            
            CreateTable(
                "dbo.Kurs",
                c => new
                    {
                        KursId = c.Int(nullable: false, identity: true),
                        KategoriaId = c.Int(nullable: false),
                        TytulKursu = c.String(nullable: false, maxLength: 100),
                        AutorKursu = c.String(nullable: false, maxLength: 100),
                        DataDodania = c.DateTime(nullable: false),
                        NazwaPlikuObr = c.String(),
                        OpisKursu = c.String(),
                        CenaKursu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bestseller = c.Boolean(nullable: false),
                        Ukryty = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KursId)
                .ForeignKey("dbo.Kategorias", t => t.KategoriaId, cascadeDelete: true)
                .Index(t => t.KategoriaId);
            
            CreateTable(
                "dbo.PozycjaZamowienias",
                c => new
                    {
                        PozycjaZamowieniaId = c.Int(nullable: false, identity: true),
                        ZamowieniaId = c.Int(nullable: false),
                        KursId = c.Int(nullable: false),
                        Ilosc = c.Int(nullable: false),
                        CenaZakupy = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PozycjaZamowieniaId)
                .ForeignKey("dbo.Kurs", t => t.KursId, cascadeDelete: true)
                .ForeignKey("dbo.Zamowienias", t => t.ZamowieniaId, cascadeDelete: true)
                .Index(t => t.ZamowieniaId)
                .Index(t => t.KursId);
            
            CreateTable(
                "dbo.Zamowienias",
                c => new
                    {
                        ZamowieniaId = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false, maxLength: 50),
                        Nazwisko = c.String(nullable: false, maxLength: 50),
                        Ulica = c.String(nullable: false, maxLength: 100),
                        Miasto = c.String(nullable: false),
                        KodPocztowy = c.String(nullable: false, maxLength: 6),
                        Telefon = c.String(),
                        Email = c.String(),
                        Komentarz = c.String(),
                        DataDodania = c.DateTime(nullable: false),
                        StanZamowienia = c.Int(nullable: false),
                        WartoscZamowienia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ZamowieniaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PozycjaZamowienias", "ZamowieniaId", "dbo.Zamowienias");
            DropForeignKey("dbo.PozycjaZamowienias", "KursId", "dbo.Kurs");
            DropForeignKey("dbo.Kurs", "KategoriaId", "dbo.Kategorias");
            DropIndex("dbo.PozycjaZamowienias", new[] { "KursId" });
            DropIndex("dbo.PozycjaZamowienias", new[] { "ZamowieniaId" });
            DropIndex("dbo.Kurs", new[] { "KategoriaId" });
            DropTable("dbo.Zamowienias");
            DropTable("dbo.PozycjaZamowienias");
            DropTable("dbo.Kurs");
            DropTable("dbo.Kategorias");
        }
    }
}
