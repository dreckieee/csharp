public abstract class Vehicle
{
    public string Make {get; private set;}
    public string Model {get; private set;}
    public int Year {get; private set;}
    public double FuelTankCapacity {get; private set;}
    public double KmPerLiter {get; private set;}
    public Vehicle (string make, string model, int year, double fuelTankCapacity, double kmPerLiter)
    {
        Make = make;
        Model = model;
        Year = year;
        FuelTankCapacity = fuelTankCapacity;
        KmPerLiter = kmPerLiter;
    }
    public abstract void FuelReport();
    public virtual void DisplayInfo ()
    {
        Console.WriteLine("\n> Displaying VEHICLE INFORMATION...");
        Console.WriteLine("Make: ".PadRight(19) + $"{Make}");
        Console.WriteLine("Model: ".PadRight(19) + $"{Model}");
        Console.WriteLine("Year: ".PadRight(19) + $"{Year}");
        Console.WriteLine("Fuel Capacity: ".PadRight(19) + $"{FuelTankCapacity} L");
        Console.WriteLine("KM/L: ".PadRight(19) + $"{KmPerLiter} km/L");
    }
}