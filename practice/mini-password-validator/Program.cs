using System;

class Program
{
    static void Main()
    {
        Console.Write("\nWelcome, ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("dreckieee");
        Console.ResetColor();
        Console.WriteLine("!\n");

        Console.WriteLine("════════════════════ Password Validator ════════════════════");


        
        while (true)
        {
            string passwordPrompt = "\nEnter your password (enter x to exit): ";
            string input = ReadString(passwordPrompt);
            
            if (input == "x"){break;}
            else
            {
                if (input.Contains(" "))
                {
                    Console.WriteLine("Cannot contain whitespaces.");
                    continue;
                }                
                else
                {
                    if (input.Length >= 8)
                    {
                        bool hasDigit = false;
                        foreach (char c in input)
                        {
                            if (char.IsDigit(c))
                            {
                                hasDigit = true;
                                break;
                            }
                        }
                        if (hasDigit) 
                        {
                            Console.WriteLine("Successfully created your password!");
                            break;
                        }
                        Console.WriteLine("Password must contain at least one (1) number.");                        
                    }
                    else 
                    {
                        Console.WriteLine("Password should be at least 8 characters.");
                        continue;
                    }
                }
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