using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔══════════════════════════════════════╗");
        Console.WriteLine("║              Q U I C K               ║");
        Console.WriteLine("║             B A T T L E              ║");
        Console.WriteLine("╚══════════════════════════════════════╝");
        Console.ResetColor();


        string playerName = ReadString("\nEnter your name: ");
        var player1 = new Player(playerName, 30, 9, 1);
        var inventory = new Inventory<Item>();
        Console.WriteLine($"\nWelcome player {player1.Name}!\n");

        
        var potion1 = new Potion("HP Potion", 2, 50);
        Console.WriteLine($"Adding {potion1.Quantity} {potion1.Name} in your backpack...");
        inventory.Add(potion1);
        Console.WriteLine("Successfully added potion in your backpack!\n");

        Console.WriteLine("Generating enemy...");
        var rng = new Random();
        Enemy enemy1 = rng.Next(1, 4) switch
        {
            1 => new Slime(),
            2 => new Goblin(),
            3 => new Troll(),
            _ => new Slime()
        };
        Console.WriteLine($"Successfully generated {enemy1.Name} as {player1.Name}'s opponent!\n");
        Console.WriteLine("Enemy Information:");
        Console.WriteLine($"Name: {enemy1.Name}");
        Console.WriteLine($"HP: {enemy1.MaxHP}");
        Console.WriteLine($"Attack: {enemy1.Attack}");
        Console.WriteLine($"Defense: {enemy1.Defense}");
        Console.WriteLine("Description:");
        Console.WriteLine(enemy1.GetUniqueTraitDescription());


        GameState gameState = GameState.PlayerTurn;
        while(player1.IsAlive && enemy1.IsAlive)
        {
            if (gameState == GameState.PlayerTurn)
            {
                Console.WriteLine("\n========================================");
                Console.WriteLine($"{player1.Name.ToUpper()}'s TURN\n");
                Console.WriteLine("[1] Attack");
                Console.WriteLine("[2] Use Potion");
                Console.WriteLine("[3] Run");
                int command = ReadInt("Enter command: ",1,3);

                if (command == 1)
                {
                    enemy1.TakeDamage(player1.Attack);
                    Console.WriteLine($"\n{player1.Name} attacked {enemy1.Name} for {Math.Clamp(player1.Attack - enemy1.Defense, 0, player1.Attack)} damage!");
                    if(!enemy1.IsAlive)
                    {
                        Console.WriteLine($"{enemy1.Name} has been defeated!");
                        gameState = GameState.Victory;
                        break;
                    }
                    else {gameState = GameState.EnemyTurn;}
                }
                else if (command == 2)
                {
                    if (inventory.Count == 0)
                    {
                        Console.WriteLine("\nYou do not have any potions left.\n");
                        continue;
                    }
                    else 
                    {
                        float temp = player1.HP;
                        player1.Heal(potion1.HealAmount);
                        Console.WriteLine($"\n{player1.Name} has been healed by {player1.HP - temp} HP!");
                        potion1.Quantity --;
                        if (potion1.Quantity == 0){inventory.Remove(potion1);}
                        gameState = GameState.EnemyTurn;
                    }
                }
                else if (command == 3)
                {
                    Console.WriteLine($"\n{player1.Name} has ran away!");
                    gameState = GameState.Defeat;
                    break;
                }

            }
            else if (gameState == GameState.EnemyTurn)
            {
                Console.WriteLine("\n========================================");
                Console.WriteLine($"{enemy1.Name.ToUpper()}'s TURN\n"); 
                player1.TakeDamage(enemy1.Attack);
                Console.WriteLine($"{enemy1.Name} attacked {player1.Name} for {Math.Clamp(enemy1.Attack - player1.Defense, 0, enemy1.Attack)} damage!");
                if(!player1.IsAlive)
                {
                    Console.WriteLine($"{player1.Name} has been defeated!");
                    gameState = GameState.Defeat;
                    break;
                }
                else {gameState = GameState.PlayerTurn;}
            }
        }
        if (gameState == GameState.Victory)
        {
            Console.WriteLine($"\n>> {player1.Name} is VICTORIOUS!");
            Console.WriteLine($"{player1.Name}'s HP LEFT: {player1.HP}\n");
        }
        else if (gameState == GameState.Defeat)
        {
            Console.WriteLine($"\n>> {player1.Name} has been DEFEATED!");
            Console.WriteLine($"{enemy1.Name}'s HP LEFT: {enemy1.HP}\n");
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
            
            else {return input;}    
        }
    }//end of ReadString method

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

}//end of Program class