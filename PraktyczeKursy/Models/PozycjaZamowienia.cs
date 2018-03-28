namespace PraktyczeKursy.Models
{
    public class PozycjaZamowienia
    {
        public int PozycjaZamowieniaId { get; set; }
        public  int ZamowieniaId { get; set; }
        public  int KursId { get; set; }
        public int Ilosc { get; set; }
        public decimal CenaZakupy { get; set; }
        
        public virtual Kurs kurs { get; set; }
        public virtual Zamowienia zamowienia { get; set; }
    }
}