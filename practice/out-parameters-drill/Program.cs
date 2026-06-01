using System;

class Program
{
    private static Random rng = new Random();
    static void Main ()
    {
        Console.WriteLine("\nWelcome, dreckieee!\n");

        GenerateStats(out int character1HP, out int character1Attack, out int character1Defense);
        EvaluateFighter(character1HP, character1Attack, character1Defense, out string character1Rank);

        GenerateStats(out int character2HP, out int character2Attack, out int character2Defense);
        EvaluateFighter(character2HP, character2Attack, character2Defense, out string character2Rank);

        var character1 = new Character("Dreck", character1HP, character1Attack, character1Defense, character1Rank);
        var character2 = new Character("Richard", character2HP, character2Attack, character2Defense, character2Rank);

        Console.WriteLine("> Character 1");
        Console.WriteLine($"Name".PadRight(13) + $"{character1.Name}");
        Console.WriteLine($"HP".PadRight(13) + $"{character1.HP}");
        Console.WriteLine($"Attack".PadRight(13) + $"{character1.Attack}");
        Console.WriteLine($"Defense".PadRight(13) + $"{character1.Defense}");
        Console.WriteLine($"Rank".PadRight(13) + $"{character1.Rank}\n");

        Console.WriteLine("> Character 2");
        Console.WriteLine($"Name".PadRight(13) + $"{character2.Name}");
        Console.WriteLine($"HP".PadRight(13) + $"{character2.HP}");
        Console.WriteLine($"Attack".PadRight(13) + $"{character2.Attack}");
        Console.WriteLine($"Defense".PadRight(13) + $"{character2.Defense}");
        Console.WriteLine($"Rank".PadRight(13) + $"{character2.Rank}\n");
    }//end of Main method

    static void GenerateStats ( out int hp, out int attack, out int defense)
    {
        hp      = rng.Next(50, 101);
        attack  = rng.Next(10, 26);
        defense = rng.Next(5,  16);
    }

    static void EvaluateFighter ( int hp, int attack, int defense, out string rank)
    {
        int total = hp + attack + defense;
        if (total < 60)         {rank = "F";}
        else if (total < 90)    {rank = "C";}
        else if (total < 120)   {rank = "B";}
        else                    {rank = "A";}
    }
}//end of Program class