namespace HGSApp.Models
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LicansePlate { get; set; }
        public abstract decimal Price { get; }
        public abstract decimal Balance { get; set; }
    }
}
