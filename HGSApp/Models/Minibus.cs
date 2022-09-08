namespace HGSApp.Models
{
    public class Minibus : Vehicle
    {
        public override decimal Price => 10.75m;
        public override decimal Balance { get; set; }
    }
}
