using System;

class Program
{
    static void Main()
    {
        Console.Write("\nHello, ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Dreckieee");
        Console.ResetColor();
        Console.WriteLine("!");
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        phonebook.Add("dreck", "09111111111");
        phonebook.Add("lynn", "09222222222");
        phonebook.Add("richard", "09999999999");
        phonebook.Add("zergei", "09888888888");
        phonebook.Add("pascual", "09777777777");
        phonebook.Add("pizarro", "09666666666");
        while (true)
        {
            Console.WriteLine("\n═══════════════════  PHONEBOOK  ═══════════════════");
            string prompt = "Enter the name you want to lookup (enter x to exit): ";
            string input = ReadString(prompt).ToLower();

            if (input == "x") 
            {
                Console.WriteLine("\nClosing Phonebook..");
                Console.Write("Press enter key to continue..");
                Console.ReadLine();
                break;
            }

            if (phonebook.ContainsKey(input))
            {
                Console.WriteLine("\nContact found!");
                Console.WriteLine($"Name: {input[0].ToString().ToUpper() + input.Substring(1)} -- {phonebook[input]}");
            }
            else {Console.WriteLine($"\n\"{input}\" Contact not found!");}
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


}//end of Program method