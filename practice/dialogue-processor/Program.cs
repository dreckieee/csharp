using System;

class Program
{
    static void Main()
    {
        string template = "You have {action} {target} for {value} damage";
        List<string> bannedWords = new List<string>();
        bannedWords.Add("fuck");
        bannedWords.Add("bitch");
        bannedWords.Add("motherfucker");
        bannedWords.Add("shit");
        bannedWords.Add("nigger");
        bannedWords.Add("cunt");

        DialogueSystem processor = new DialogueSystem(template, bannedWords);

        while (true)
        {
            string prompt = "Write a command for your character (enter x to exit program): ";
            string? input = ReadString(prompt);

            if(input == "x") 
            {
                Console.WriteLine("\nExiting program..");
                Console.Write("Press enter key to continue..");
                Console.ReadLine();
                break;
            }
            else
            {
                string command = processor.ProcessCommand(input);
                Console.WriteLine(command);
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

}//end of Program
