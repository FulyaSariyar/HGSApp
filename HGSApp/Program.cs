using HGSApp.Models;

Console.WriteLine("HGS APP");


var tollGate = new TollGate();

var car1 = new Car()
{
    Balance = 100,
    Name = "Ali",
    Surname = "Demir",
    LicansePlate = "34 ABC 1234"
};
var car2 = new Minibus()
{
    Balance = 200,
    Name = "Veli",
    Surname = "Çelik",
    LicansePlate = "34 ABC 3214"
};
var car3 = new Bus()
{
    Balance = 300,
    Name = "Veli",
    Surname = "Demir",
    LicansePlate = "34 ABC 5345"
};

tollGate.Pass(car1);
tollGate.Pass(car2);
tollGate.Pass(car3);

var total = tollGate.DailyReport(DateTime.UtcNow);

Console.WriteLine($"Total earnings: {total:#.00}  - {DateTime.UtcNow:dd/MM/yyyy}");