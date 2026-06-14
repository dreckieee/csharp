public class SupportTicket
{
    public string Description {get; private set;}
    public SeverityLevel Severity {get; private set;}
    public SupportTicket (string description, SeverityLevel severity)
    {
        Description = description;
        Severity = severity;
    }
    public void Process ()
    {
        throw new TicketException (Description, Severity);
    }
}