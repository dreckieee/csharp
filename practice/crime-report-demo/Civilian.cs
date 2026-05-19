using System;

public class Civilian : Suspect
{


    public Civilian (string name, int age, SuspectStatus status) : base (name, age, status)
    {

    }

    public override void GetInfo()
    {
        Console.WriteLine($"\nName: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Status: {Status}");
    }
}