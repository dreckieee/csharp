using System;

class Program 
{
    static void Main ()
    {
        List <Enemy> enemies = new List<Enemy>();

        Goblin newGoblin = new Goblin ("Goblin1", 100m);
        Orc newOrc = new Orc ("Orc1", 1000m);
        Dragon newDragon = new Dragon ("Dragon1", 1000m);

        enemies.Add(newGoblin);
        enemies.Add(newOrc);
        enemies.Add(newDragon);

        foreach (Enemy e in enemies)
        {
            if (e is ILootable lootable )
            {
                Console.WriteLine($"\n{e.Name} is lootable!");
                lootable.DropLoot();
            }
            if (e is IElite elite)
            {
                Console.WriteLine($"{e.Name} is an elite!");
                elite.ShowEliteTitle();
            }
        }
        Console.Write("\nPress enter key to continue..");
        Console.ReadLine();
    }//end of Main method



}//end of Program class