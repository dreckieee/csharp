public class Truck : Vehicle
{
    public double CargoCapacityTons {get; private set;}

    public Truck (string make, string model, int year, double fuelTankCapacity, double kmPerLiter, double cargoCapacityTons) : base (make, model, year, fuelTankCapacity, kmPerLiter)
    {
        CargoCapacityTons = cargoCapacityTons;
    }
    public override void FuelReport()
    {
        Console.WriteLine("\n> Displaying FUEL REPORT...");
        Console.WriteLine("Efficiency: ".PadRight(19) + $"{KmPerLiter} km/L");
        Console.WriteLine("Full tank range: ".PadRight(19) + $"{KmPerLiter * FuelTankCapacity:F2} km");
        Console.WriteLine("Cargo capacity: ".PadRight(19) + $"{CargoCapacityTons} tons");
    }

    public override void DisplayInfo ()
    {
        base.DisplayInfo();
        Console.WriteLine("Cargo capacity: ".PadRight(19) + $"{CargoCapacityTons} tons");
    }
}