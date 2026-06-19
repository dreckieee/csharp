public class Car : Vehicle
{
    public int NumberOfDoors {get; private set;}

    public Car (string make, string model, int year, double fuelTankCapacity, double kmPerLiter, int numberOfDoors) : base (make, model, year, fuelTankCapacity, kmPerLiter)
    {
        NumberOfDoors = numberOfDoors;

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
        Console.WriteLine("Doors: ".PadRight(19) + $"{NumberOfDoors}");
    }
}