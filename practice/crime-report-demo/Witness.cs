using System;

public class Witness : Suspect, IWitness
{

    public string Testimony {get; set;}
    public Witness (string name, int age, SuspectStatus status, string testimony) : base (name, age, status)
    {
        Testimony = testimony;
    }

    public override void GetInfo()
    {
        Console.WriteLine($"\nName: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine($"Testimony: {Testimony}");
    }
    public void GetTestimony()
    {
        Console.WriteLine($"\nThe TESTIMONY of \"{Name}\" is as following: \"{Testimony}\".");
    }
}