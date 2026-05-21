using System;

public class CommandParser
{
    public string Command {get; set;}
    public CommandParser (string command)
    {
        Command = command;
    }
    public ParsedCommand Parse()
    {
        string normalized = Command.Trim().ToLower();
        string[] parts = normalized.Split(':');
        return new ParsedCommand
        {
            Action = parts[0],
            Target = parts.Length > 1 ? parts[1] : "",
            Value  = parts.Length > 2 ? parts[2] : ""
        };
    }
}