using System;

class Program
{
    private static Random rng = new Random();
    static void Main ()
    {
        Console.WriteLine("Welcome, dreckieee!\n");

        var fighter1 = new Fighter("DRECK", rng.Next(10,21));
        var fighter2 = new Fighter("LYNN", rng.Next(10,21));

        bool crit = rng.Next(1,101) <= 20;
        PrintDamage(fighter1.Attack);
        PrintDamage(fighter1.Attack, fighter1.Name);
        PrintDamage(fighter1.Attack, fighter1.Name, crit);

        Console.WriteLine();
        crit = rng.Next(1,101) <= 20;
        PrintDamage(fighter2.Attack);
        PrintDamage(fighter2.Attack, fighter2.Name);
        PrintDamage(fighter2.Attack, fighter2.Name, crit);

    }//end of Main method

    static void PrintDamage (int damage)
    {
        Console.WriteLine($">Damage dealt: {damage} damage!");
    }

    static void PrintDamage (int damage, string attackerName)
    {
        Console.WriteLine($">{attackerName} deals {damage} damage!");
    }

    static void PrintDamage (int damage, string attackerName, bool isCrit)
    {
        if (isCrit) {Console.WriteLine($">Critical Hit! {attackerName} deals {damage*2} damage!");}
        else {Console.WriteLine($">{attackerName} deals {damage} damage!");}
    }
}//end of Program class