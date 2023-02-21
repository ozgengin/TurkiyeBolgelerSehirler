namespace TurkiyeBolgelerSehirler.Classes
{
    public class Sehir
    {
        public int Id { get; set; }
        public int BolgeId { get; set; }
        public string Slug { get; set; } = null!;
        public string SehirAd { get; set; } = null!;
        public int Nufus { get; set; }

        public Bolge Bolge { get; set; } = null!;
    }
}
