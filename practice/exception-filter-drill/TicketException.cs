public class TicketException : Exception
{
    public SeverityLevel Severity {get; private set;}
    public TicketException (string message, SeverityLevel severity) : base (message)
    {
        Severity = severity;
    }
}