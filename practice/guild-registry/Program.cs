using System;

class Program
{
    static void Main()
    {
        
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("╔══════════════════════════════════════╗");
        Console.WriteLine("║               G U I L D              ║");
        Console.WriteLine("║            R E G I S T R Y           ║");
        Console.WriteLine("╚══════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();

        Guild guild = new Guild();
        while(true)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n═════════════════ MENU ══════════════════");
            Console.WriteLine("1 -- Add Member");
            Console.WriteLine("2 -- List all");
            Console.WriteLine("3 -- Find by name");
            Console.WriteLine("4 -- Train member");
            Console.WriteLine("5 -- Inspect");
            Console.WriteLine("6 -- Show elites");
            Console.WriteLine("0 -- Exit");
            Console.ResetColor();
            string prompt = "Enter a command (refer above): ";
            int input = ReadInt(prompt, 0,6);

            if ( input == 1 )
            {
                string newMemberName = ReadString("\nEnter the NAME of new Member: ");

                Console.WriteLine("\n1 -- Warrior");
                Console.WriteLine("2 -- Mage");
                Console.WriteLine("3 -- Ranger");
                int newMemberRole = ReadInt("Enter the ROLE of new Member (refer above): ",1,3);

                if ( newMemberRole == 1 ) 
                { 
                    guild.AddMember(new Warrior (newMemberName));
                    Console.WriteLine($"You have successfully registered {newMemberName}!");
                }
                else if ( newMemberRole == 2 ) 
                { 
                    guild.AddMember(new Mage (newMemberName));
                    Console.WriteLine($"You have successfully registered {newMemberName}!");
                }
                else if ( newMemberRole == 3 ) 
                { 
                    guild.AddMember(new Ranger (newMemberName));
                    Console.WriteLine($"You have successfully registered {newMemberName}!");
                }
            }


            else if ( input == 2 ) { guild.ListAll(); }


            else if ( input == 3 )
            {
                Member? found = guild.FindByName(ReadString("\nEnter the NAME of the member you want search: "));
                if ( found == null )
                {
                    Console.WriteLine("\nNo match found!");
                }
                else 
                {
                    Console.WriteLine("\nMatch found!");
                    Console.WriteLine($"\nName: {found.Name}");
                    Console.WriteLine($"Rank: {found.Rank}");
                    if(found is Warrior){Console.WriteLine("Role: Warrior");}
                    else if(found is Mage){Console.WriteLine("Role: Mage");}
                    else if(found is Ranger){Console.WriteLine("Role: Ranger");}
                }
            }


            else if ( input == 4 )
            {
                Member? found = guild.FindByName(ReadString("\nEnter the NAME of the member you want train: "));
                if ( found == null )
                {
                    Console.WriteLine("\nNo match found!");
                }
                else 
                {
                    Console.WriteLine("\nMatch found!");
                    Console.WriteLine($"\nName: {found.Name}");
                    Console.WriteLine($"Rank: {found.Rank}");
                    if(found is Warrior w)
                    {
                        Console.WriteLine("Role: Warrior");
                        w.Strength += 100;
                        Console.WriteLine($"You have successfully trained {found.Name}! +100 to Strength!");
                        found.Promote();
                    }
                    else if(found is Mage m)
                    {
                        Console.WriteLine("Role: Mage");
                        m.SpellsLearned += 5;
                        Console.WriteLine($"You have successfully trained {found.Name}! +5 to Spells Learned!");
                        found.Promote();
                    }
                    else if(found is Ranger r)
                    {
                        Console.WriteLine("Role: Ranger");
                        r.Kills += 15;
                        Console.WriteLine($"You have successfully trained {found.Name}! +15 to Kills!");
                        found.Promote();
                    }
                }                
            }


            else if ( input == 5 )
            {
                string inspectByName = ReadString("\nEnter the NAME of the member you want inspect: ");
                Member? found = guild.FindByName(inspectByName);
                if ( found == null )
                {
                    Console.WriteLine("\nNo match found!");
                }
                else 
                {
                    Console.WriteLine("\nMatch found!");
                    Console.WriteLine($"\nName: {found.Name}");
                    Console.WriteLine($"Rank: {found.Rank}");
                    guild.Inspect(found);
                }                        
            }


            else if ( input == 6 )
            {
                guild.ShowElites();
            }


            else if ( input == 0 )
            {
                Console.WriteLine("\nClosing the Guild Registry..");
                Console.Write("Press enter key to continue..");
                Console.ReadLine();
                break;
            }
        }
    }//end of Main method


    public static int ReadInt(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                if (result >= min && result <= max)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Invalid. Input must be a minimum of {min} and maximum of {max}. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid. Enter an integer number. Try again.");
            }
        }
    }//end of ReadInt method



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