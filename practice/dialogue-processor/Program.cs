using System;

class Program
{
    static void Main()
    {
        string template = "You dealt {damage} damage to {enemy}.";
        DialogueTemplate dialogue1 = new DialogueTemplate (template);
        Dictionary<string, string> placeholders = new Dictionary<string, string>();
        placeholders.Add("damage", "15");
        placeholders.Add("enemy", "Goblin");
        string result = dialogue1.Process(placeholders);
        Console.WriteLine($"This is the result: {result}");

        List<string> bannedWordList = new List<string>();
        bannedWordList.Add("idiot");
        bannedWordList.Add("bitch");
        bannedWordList.Add("fuck");

        DialogueFilter dialogueFilter = new DialogueFilter(bannedWordList);
        string banCheck1 = "yeah right fuck you!";
        string banCheck2 = "let me be your BITCH";
        string banCheck3 = "i love you";
        
        CheckBan(banCheck1, dialogueFilter);
        CheckBan(banCheck2, dialogueFilter);
        CheckBan(banCheck3, dialogueFilter);

        string command = "  Attack:Goblin:15  ";
        CommandParser parser = new CommandParser(command);
        ParsedCommand parsed = parser.Parse();

        Console.WriteLine($"\nCOMMAND PARSE CHECK -- \"{command}\"");
        Console.WriteLine($"Action: {parsed.Action}");
        Console.WriteLine($"Target: {parsed.Target}");
        Console.WriteLine($"Value:  {parsed.Value}");
        
    }//end of Main method

    static void CheckBan (string dialogue, DialogueFilter filter)
    {
        Console.WriteLine($"\nBAN CHECK -- \"{dialogue}\"");
        if (!filter.IsClean(dialogue)) {Console.WriteLine("You cannot speak bad words!");}
        else {Console.WriteLine("You have spoken good words only");}
    }
}//end of Program
