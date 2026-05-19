using System;
public class Criminal : Suspect, ICriminal
{

    public string Charges {get; set;}
    public Criminal (string name, int age, SuspectStatus status, string charges) : base (name, age, status)
    {
        Charges = charges;
    }

    public override void GetInfo()
    {
        Console.WriteLine($"\nName: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine($"Charges: {Charges}");
    }
    public void GetCharges()
    {
        Console.WriteLine($"\nCriminal \"{Name}\" is CHARGED with {Charges}.");
    }
}