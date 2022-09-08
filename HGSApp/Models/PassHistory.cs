namespace HGSApp.Models
{
    public class PassHistory
    {
        public Vehicle Vehicle { get; set; }
        public DateTime Date { get; private set; } = DateTime.UtcNow;
        public decimal Price { get; set; }
    }
}
