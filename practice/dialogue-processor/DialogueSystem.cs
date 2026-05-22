using System;
using System.Diagnostics;

public class DialogueSystem
{
    private DialogueTemplate _template;
    private DialogueFilter _filter;
    public DialogueSystem (string template, List<string> bannedWords)
    {
        _template = new DialogueTemplate(template);
        _filter = new DialogueFilter(bannedWords);
    }

    public string ProcessCommand (string command)
    {
        string processedCommand = "";

        //PARSE THE COMMAND
        CommandParser parser = new CommandParser(command);
        ParsedCommand parsed = parser.Parse();
        if (!parsed.IsValid)
        {
            processedCommand = "Invalid Command!";
            return processedCommand;
        }
        else
        {
            //BUILD THE DIALOGUE
            Dictionary<string, string> placeholders = new Dictionary<string, string>();
            placeholders.Add("action", parsed.Action);
            placeholders.Add("target", parsed.Target);
            placeholders.Add("value", parsed.Value);
            processedCommand = _template.Process(placeholders);

            //FILTERS THE STRING
            if (_filter.IsClean(processedCommand))
            {
                return processedCommand;
            }
            else
            {
                processedCommand = "Message blocked.";
                return processedCommand;
            }
        }



    }

}
 

