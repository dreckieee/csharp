class Program
{
    static void Main ()
    {
        var vehicles = new List<Vehicle>();
        var vehicleCar = new Car ("Toyota", "Vios", 2019, 42D, 14.1, 4);
        vehicles.Add(vehicleCar);
        var vehicleTruck = new Truck ("Ford", "F-150", 2017, 110D, 11D, 1.21);
        vehicles.Add(vehicleTruck);
        var vehicleMotorcycle = new Motorcycle ("Yamaha", "Aerox", 2026, 5.5, 40D, false);
        vehicles.Add(vehicleMotorcycle);
        
        int count = 1;
        foreach (Vehicle v in vehicles)
        {
            Console.WriteLine($"\n=============== VEHICLE #{count} ===============");
            v.DisplayInfo();
            v.FuelReport();
            
            count++;
        }

        Console.WriteLine($"\n==========================================");
        Console.WriteLine("\nDisplayed all vehicles in the list!\n");
        
    }//end of Main method
}//end of Program class