using System;

class Program
{
    static void Main()
    {
        
        Warrior newWarrior1 = new Warrior("warrior1", 100m);
        Warrior newWarrior2 = new Warrior("dummy", 1000m);
        Mage newMage1 = new Mage("mage1", 100m, 50m);
        Archer newArcher1 = new Archer("archer1", 100m);
        List<Unit> squad1 = new List<Unit>();
        List<Unit> squad2 = new List<Unit>();
        squad1.Add(newWarrior1);
        squad2.Add(newWarrior2);
        squad1.Add(newMage1);
        squad1.Add(newArcher1);

        Console.WriteLine("======================= Team A ======================");
        foreach(Unit u in squad1)
        {
            if(u is Mage mage)
            {
                Console.WriteLine($"{mage.Name} -- {mage.CurrentHP} HP - {mage.Mana} Mana");
            }
            else
            {
                Console.WriteLine($"{u.Name} -- {u.CurrentHP} HP");
            }
        }
        Console.WriteLine("\n                          VS                        \n");
        foreach(Unit u in squad2)
        {
            Console.WriteLine($"{u.Name} -- {u.CurrentHP} HP\n");
        }
        Console.WriteLine("=====================================================");
        
        Unit? found = squad2.Find(f => f.Name == "dummy");
        if(found == null)
        {
            Console.WriteLine("Match not found!");
        }
        else
        {
            foreach(Unit u in squad1)
            {
                u.Attack(found);
                Console.WriteLine($"{found.Name} -- {found.CurrentHP} HP\n");
            }


            Mage? found1 = squad1.Find(f => f.Name == "mage1") as Mage;
            if(found1 == null)
            {
                Console.WriteLine("Match not found!");
            }
            else
            {
                found.Attack(found1);
                Console.WriteLine($"{found1.Name} -- {found1.CurrentHP} HP - {found1.Mana} Mana\n");
                found1.Heal(30m);
                Console.WriteLine($"{found1.Name} -- {found1.CurrentHP} HP - {found1.Mana} Mana\n");


                foreach(Unit u in squad1)
                {
                    u.Attack(found);
                    Console.WriteLine($"{found.Name} -- {found.CurrentHP} HP\n");
                }

                foreach(Unit u in squad1)
                {
                    u.Attack(found);
                    Console.WriteLine($"{found.Name} -- {found.CurrentHP} HP\n");
                }
                found1.Heal(30m);
                Console.WriteLine($"{found1.Name} -- {found1.CurrentHP} HP - {found1.Mana} Mana\n");

            }
        }


    }//end of Main method


}//end of Program class
