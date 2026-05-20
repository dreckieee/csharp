using System;

public class BugReport : Ticket, IBugReport
{
    public string StepsToReproduce {get; set;}
    public BugReport (string title, TicketPriority priority, string stepsToReproduce) : base(title, priority)
    {
        StepsToReproduce = stepsToReproduce;
    }
    public override void GetDetails()
    {
        Console.WriteLine($"\nTitle: {Title}");
        Console.WriteLine($"Priority: {Priority}");
        Console.WriteLine($"Steps to reproduce:\n{StepsToReproduce}");
    }

    public void Reproduce()
    {
        Console.WriteLine($"\nSteps to reproduce:\n{StepsToReproduce}");
    }
}