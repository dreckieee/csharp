using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nWelcome, dreckieee!\n");
        var dog1 = new Dog ("Pandong", 10);
        var cat1 = new Cat ("Britpang", 9);
        var parrot1 = new Parrot ("Dovey", 3);

        var animals = new Shelter<Animal>();
        animals.Add(dog1);
        animals.Add(cat1);
        animals.Add(parrot1);

        var shelter = animals.GetAll();

        for (int x = 0; x < shelter.Count; x++)
        {
            Console.WriteLine($"\n> {x+1}");
            Console.WriteLine("SOUND:".PadRight(11) + shelter[x].MakeSound());
            if (shelter[x] is ITrainable t) {Console.WriteLine($"TRAINING:".PadRight(11) + t.GetTrainingLevel());}
            if (shelter[x] is IAdoptable a) {Console.WriteLine($"PROFILE:\n{a.GetAdoptionProfile()}");}
        }

    }//end of Main method
}//end of Program class