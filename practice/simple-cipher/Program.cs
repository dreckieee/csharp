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
        string encrypted = "";
        int count = 0;
        char[] messageChars = message.ToCharArray();
        foreach (char c in messageChars)
        {
            if (char.IsLetter(c))
            {
                if (char.IsUpper(c)) 
                {
                    messageChars[count] = (char)(((c - 'A' + shift) % 26) + 'A');
                }
                else {messageChars[count] = (char)(((c - 'a' + shift) % 26) + 'a');}
            }
            count ++;
        }
        encrypted = new string(messageChars);
        return encrypted;
    }

    public static string Decrypt (string message, int shift)
    {
        string decrypted = "";
        int count = 0;
        char[] messageChars = message.ToCharArray();
        foreach (char c in messageChars)
        {
            if (char.IsLetter(c))
            {
                if (char.IsUpper(c)) 
                {
                    messageChars[count] = (char)(((c - 'A' + (26 - shift)) % 26) + 'A');
                }
                else {messageChars[count] = (char)(((c - 'a' + (26 - shift)) % 26) + 'a');}
            }
            count ++;
        }
        decrypted = new string(messageChars);
        return decrypted;
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