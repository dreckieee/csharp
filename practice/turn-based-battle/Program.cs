using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=============== Swordsman vs Archer ===============");
        Swordsman newSwordsman = new Swordsman("Kenshin", 200m);
        Archer newArcher = new Archer("Legolas", 200m);
        int round = 1;

        Console.WriteLine($"\nNAME: {newSwordsman.Name}\t\t\tNAME: {newArcher.Name}\nHP: {newSwordsman.HP}               VS\tHP: {newArcher.HP}\nCLASS: Swordsman\t\tCLASS: Archer");
        
        Random turn = new Random();
        while (newSwordsman.HP > 0 && newArcher.HP > 0)
        {
            Console.WriteLine($"\nROUND {round}!");
            if( turn.Next(1,3) == 1) //to determine who attacks first
            {
                newSwordsman.Attack(newArcher);
                if(newArcher.HP <= 0){break;}
                newArcher.Attack(newSwordsman);
            }

            else 
            {
                newArcher.Attack(newSwordsman);
                if(newSwordsman.HP <= 0){break;}
                newSwordsman.Attack(newArcher);
            }

            Console.WriteLine($"\n{newSwordsman.Name} -- {newSwordsman.HP}");
            Console.WriteLine($"{newArcher.Name} -- {newArcher.HP}\n");

            round ++;
        }

        if (newSwordsman.HP <= 0)
        {
            Console.WriteLine($"\n{newSwordsman.Name}'s HP has dropped to 0");
            Console.WriteLine($"{newArcher.Name} has defeated {newSwordsman.Name}!");
        }
        else
        {
            Console.WriteLine($"\n{newArcher.Name}'s HP has dropped to 0");
            Console.WriteLine($"{newSwordsman.Name} has defeated {newArcher.Name}!");
        }
        Console.WriteLine("\n=============== Swordsman vs Archer ===============");
        Console.Write("\nPress enter key to continue...");
        Console.ReadLine();
        Console.WriteLine();
    }//end of Main method



}//end of Program class