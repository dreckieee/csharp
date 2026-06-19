public class Motorcycle : Vehicle
{
    public bool HasSideCar {get; private set;}

    public Motorcycle (string make, string model, int year, double fuelTankCapacity, double kmPerLiter, bool hasSideCar) : base (make, model, year, fuelTankCapacity, kmPerLiter)
    {
        HasSideCar = hasSideCar;
    }
    public override void FuelReport()
    {
        Console.WriteLine("\n> Displaying FUEL REPORT...");
        Console.WriteLine("Efficiency: ".PadRight(19) + $"{KmPerLiter} km/L");
        Console.WriteLine("Full tank range: ".PadRight(19) + $"{KmPerLiter * FuelTankCapacity:F2} km");
    }

    public override void DisplayInfo ()
    {
        base.DisplayInfo();
        Console.WriteLine("Has a side car: ".PadRight(19) + $"{HasSideCar}");
    }
}