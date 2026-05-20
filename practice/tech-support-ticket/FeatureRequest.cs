using System;

public class FeatureRequest : Ticket, IFeatureRequest
{
    public string Requester {get; set;}
    public string RequestDescription {get; set;}
    public FeatureRequest (string title, TicketPriority priority, string requester, string requestDescription) : base(title, priority)
    {
        Requester = requester;
        RequestDescription = requestDescription;
    }
    public override void GetDetails()
    {
        Console.WriteLine($"\nTitle: {Title}");
        Console.WriteLine($"Priority: {Priority}");
        Console.WriteLine($"Requester: {Requester}");
        Console.WriteLine($"Request Description: {RequestDescription}");
    }

    public void SubmitRequest()
    {
        Console.WriteLine("\nSubmitting Feature Request..");
        Console.WriteLine($"Requester: {Requester}");
        Console.WriteLine($"Request Description: {RequestDescription}");
    }
}