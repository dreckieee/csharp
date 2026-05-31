using System;


class Program
{
    private static Random rng = new Random();
    static void Main()
    {
        string playerNamePrompt = "Welcome! Enter your name: ";
        string playerName = ReadString(playerNamePrompt);
        int playerMinDamage = rng.Next(10,26);
        int playerMaxDamage = rng.Next(27,53);
        int playerDefense = rng.Next(5,16);
        Console.WriteLine();

        string enemyNamePrompt = "What about your enemy's name: ";
        string enemyName = ReadString(enemyNamePrompt);
        int enemyMinDamage = rng.Next(10,26);
        int enemyMaxDamage = rng.Next(27,53);
        int enemyDefense = rng.Next(5,16);
        Console.WriteLine();

        Console.WriteLine($"{playerName.ToUpper()}  -VS-  {enemyName.ToUpper()}\n");

        Console.WriteLine($">> {playerName}'s Turn..");
        bool crit = IsCriticalHit();
        int finalDamage = CalculateFinalDamage(enemyDefense, playerMinDamage, playerMaxDamage, crit);
        PrintCombatResult(playerName, enemyName, finalDamage, crit);

        Console.WriteLine($">> {enemyName}'s Turn..");
        crit = IsCriticalHit();
        finalDamage = CalculateFinalDamage(playerDefense, enemyMinDamage, enemyMaxDamage, crit);
        PrintCombatResult(enemyName, playerName, finalDamage, crit);

    }//end of Main method


    public static string ReadString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Cannot be empty. Try again.");
            }
            
            else {return input;}    
        }
    }//end of ReadString method


    public static int RollDamage (int minDamage, int maxDamage)
    {
        int rolledDamage = rng.Next(minDamage, maxDamage+1);
        return rolledDamage;
    }//end of RollDamage method


    public static bool IsCriticalHit (int chancePercentage = 20)
    {
        bool crit = rng.Next(1,101) <= chancePercentage;
        return crit;
    }//end of IsCriticalHit method


    public static int ApplyDefense (int rolledDamage, int defense)
    {
        int damage = Math.Clamp(rolledDamage - defense, 0, rolledDamage);
        return damage;
    }//end of ApplyDefense method


    public static int CalculateFinalDamage (int defense, int minDamage, int maxDamage, bool crit)
    {
        int finalDamage = crit ? ApplyDefense((RollDamage(minDamage, maxDamage) * 2), defense) : ApplyDefense(RollDamage(minDamage,maxDamage), defense);
        return finalDamage;
    }//end of CalculateFinalDamage method


    public static void PrintCombatResult (string attackerName, string defenderName, int finalDamage, bool crit)
    {
        Console.WriteLine($"\n{attackerName} is attacking {defenderName}!");
        if (crit)
        {
            Console.WriteLine("Critical hit!");
            Console.WriteLine($"{attackerName} deals {finalDamage} to {defenderName}!\n");
        }
        else {Console.WriteLine($"{attackerName} deals {finalDamage} to {defenderName}!\n");}
    }//end of PrintCombatResult method


}//end of Program class