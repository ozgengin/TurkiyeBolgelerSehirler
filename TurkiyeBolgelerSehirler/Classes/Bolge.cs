namespace TurkiyeBolgelerSehirler.Classes
{
    public class Bolge
    {
        public int Id { get; set; }
        public string Slug { get; set; } = null!;
        public string BolgeAd { get; set; } = null!; 

        public List<Sehir> Sehirler { get; set; }
    }
}
