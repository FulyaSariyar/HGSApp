namespace HGSApp.Models
{
    public class Bus : Vehicle
    {
        public override decimal Price => 12.15m;
        public override decimal Balance { get; set; }
    }
}
