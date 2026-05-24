using System;

class Program
{
    static void Main()
    {
        Console.Write("\nWelcome, ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Dreckieee");
        Console.ResetColor();
        Console.WriteLine("!\n");      

        List<Monster> monsters = new List<Monster>();
        CommonMonster commonMonster1 = new CommonMonster("Green Slime", "Slime (Common Monster)", "The weakest slime for newbies.", "Green Forest");
        CommonMonster commonMonster2 = new CommonMonster("Green Vine", "Plant (Common Monster)", "A vine that got blessed by a fairy.", "Green Forest");
        CommonMonster commonMonster3 = new CommonMonster("Green Eagle", "Bird(Common Monster)", "The fairy queen's favorite food.", "Green Forest");
        BossMonster bossMonster1 = new BossMonster("Green Golem", "Golem (Boss Monster)", "Eternal slaves to the fairy queen as her bodyguard.", "Lightning", "1x Golem Core, 1x Fairy Essence");
        BossMonster bossMonster2 = new BossMonster("Green Fairy Queen", "Fairy (Boss Monster)", "Ruler of the Green Forest.", "Fire", "5x Fairy Essence, 1x Fairy Queen Dust");
        monsters.Add(commonMonster1);
        monsters.Add(commonMonster2);
        monsters.Add(commonMonster3);
        monsters.Add(bossMonster1);
        monsters.Add(bossMonster2);



        Console.WriteLine("========================= MONSTER CODEX =========================");
        int count = 1;
        foreach (Monster m in monsters)
        {
            Console.WriteLine($"\n> Entry#{count}");
            Console.WriteLine(m.GetEntry());
            count ++;
        }
        Console.WriteLine("========================= MONSTER CODEX =========================");
        while (true)
        {
            string menuPrompt = "\n\nSearch Monster Codex(enter x to exit): ";
            string command = ReadString(menuPrompt).ToLower();

            if (command == "x") 
            {
                Console.WriteLine("Exiting menu...");
                Console.Write("Press enter key to continue...");
                Console.ReadLine();
                break;
            }
            else
            {
                Console.WriteLine($"Searching for \"{command}\" in the codex..\n");
                bool match = false;
                foreach (Monster m in monsters)
                {
                    if (m.GetEntry().ToLower().Contains(command)) 
                    {
                        Console.WriteLine("\nMatch found!");
                        Console.WriteLine(m.GetEntry());
                        match = true;
                    }
                }
                if (!match) {Console.WriteLine($"There are no \"{command}\" in the codex");}
            }
        }
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
            else
            {
                return input;
            }
        }
    }//end of ReadString method

}//end of Program class