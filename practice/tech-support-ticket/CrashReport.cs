using System;

public class CrashReport : Ticket, ICrashReport
{
    public string ErrorCode {get; set;}
    public string ErrorDescription {get; set;}
    public CrashReport (string title, TicketPriority priority, string errorCode, string errorDescription) : base(title, priority)
    {
        ErrorCode = errorCode;
        ErrorDescription = errorDescription;
    }
    public override void GetDetails()
    {
        Console.WriteLine($"\nTitle: {Title}");
        Console.WriteLine($"Priority: {Priority}");
        Console.WriteLine($"Error Code: {ErrorCode}");
        Console.WriteLine($"Error Description: {ErrorDescription}");
    }

    public void ReportError()
    {
        Console.WriteLine("\nReporting Error..");
        Console.WriteLine($"Error Code: {ErrorCode}");
        Console.WriteLine($"Error Description: {ErrorDescription}");
    }
}