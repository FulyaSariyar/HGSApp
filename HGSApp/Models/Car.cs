namespace HGSApp.Models
{
    public class Car : Vehicle
    {
        public override decimal Price => 8.25m;

        public override decimal Balance { get; set; }
    }
}
