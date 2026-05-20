public abstract class Ticket
{
    public string Title {get; set;}
    public TicketPriority Priority {get; set;}
    public Ticket (string title, TicketPriority priority)
    {
        Title = title;
        Priority = priority;        
    }
    public abstract void GetDetails();
}