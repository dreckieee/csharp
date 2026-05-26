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
        string messagePrompt = "Enter a message to encrypt: ";
        string inputMessage = ReadString(messagePrompt);

        string shiftPrompt = "Enter the shift number: ";
        int inputShift = ReadIntNoMax(shiftPrompt, 1);

        string encrypt = Encrypt(inputMessage, inputShift);
        string decrypted = Decrypt(encrypt, inputShift);
        Console.WriteLine($"\nMessage: ".PadRight(16) + $"{inputMessage}");
        Console.WriteLine($"Shift: ".PadRight(15) + $"{inputShift}");
        Console.WriteLine($"Encrypted: ".PadRight(15) + $"{encrypt}");
        Console.WriteLine($"Decrypted: ".PadRight(15) + $"{decrypted}");


    }//end of Main method

    public static string Encrypt (string message, int shift)
    {
        char[] messageChars = message.ToCharArray();
        for (int x = 0; x < messageChars.Length; x++)
        {
            if (char.IsLetter(messageChars[x]))
            {
                if (char.IsUpper(messageChars[x])) {messageChars[x] = (char)(((messageChars[x] - 'A' + shift) % 26) + 'A');}
                else {messageChars[x] = (char)(((messageChars[x] - 'a' + shift) % 26) + 'a');}
            }
        }

        string encrypted = new string(messageChars);
        return encrypted;
    }


    public static string Decrypt (string message, int shift)
    {
        char[] messageChars = message.ToCharArray();
        for (int x = 0; x < messageChars.Length; x++)
        {
            if (char.IsLetter(messageChars[x]))
            {
                if (char.IsUpper(messageChars[x])) {messageChars[x] = (char)(((messageChars[x] - 'A' + (26 - shift)) % 26) + 'A');}
                else {messageChars[x] = (char)(((messageChars[x] - 'a' + shift) % 26) + 'a');}
            }
            
        }

        string encrypted = new string(messageChars);
        return encrypted;
    }


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


    public static int ReadIntNoMax(string prompt, int min)
    {
        while (true)
        {
            Console.Write(prompt);
            if(int.TryParse(Console.ReadLine(), out int result))
            {
                if (result >= min)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Invalid. Must be at least {min}. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid. Enter an integer number. Try again.");
            }
        }
    }//end ReadIntNoMax method

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