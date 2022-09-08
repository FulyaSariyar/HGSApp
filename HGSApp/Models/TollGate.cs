namespace HGSApp.Models
{
    public class TollGate
    {
        public List<PassHistory> PassHistories { get; set; } = new List<PassHistory>();
        public void Pass(Vehicle vehicle)
        {
            vehicle.Balance -= vehicle.Price;

            PassHistories.Add(new PassHistory
            {
                Vehicle = vehicle,
                Price = vehicle.Price,
            });
        }
        public decimal DailyReport(DateTime date)
        {
            return this.PassHistories.Where(x => x.Date.Date == date.Date).Sum(x => x.Price);
        }
    }
}
