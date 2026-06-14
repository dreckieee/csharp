class Program
{
    static void Main ()
    {
        var tickets = new List<SupportTicket>();

        var ticket = new SupportTicket ("Mouse not working", SeverityLevel.Low);
        tickets.Add(ticket);

        ticket = new SupportTicket("Email access lost", SeverityLevel.Escalated);
        tickets.Add(ticket);

        ticket = new SupportTicket("Server is down", SeverityLevel.Critical);
        tickets.Add(ticket);

        ticket = new SupportTicket("Printer offline", SeverityLevel.Low);
        tickets.Add(ticket);

        ticket = new SupportTicket("Database corrupted", SeverityLevel.Critical);
        tickets.Add(ticket);

        Console.WriteLine();
        int count = 1;
        foreach (SupportTicket st in tickets)
        {
            try
            {
                st.Process();
            }
            catch (TicketException ex) when (ex.Severity == SeverityLevel.Critical)
            {
                Console.WriteLine($"> {count} --".PadRight(8) + $"[{ex.Severity} Error]".PadRight(19) + $"IMMEDIATE ACTION REQUIRED: \"{ex.Message}\""); 
            }
            catch (TicketException ex) when (ex.Severity == SeverityLevel.Escalated)
            {
                Console.WriteLine($"> {count} --".PadRight(8) + $"[{ex.Severity} Error]".PadRight(19) + $"Forwarded to Senior Support: \"{ex.Message}\""); 
            }
            catch (TicketException ex) when (ex.Severity == SeverityLevel.Low)
            {
                Console.WriteLine($"> {count} --".PadRight(8) + $"[{ex.Severity} Error]".PadRight(19) + $"Fix scheduled by Junior Support: \"{ex.Message}\""); 
            }
            catch (TicketException ex)
            {
                Console.WriteLine($"> {count} --".PadRight(8) + $"[{ex.Severity} Error]".PadRight(30) + $"UNEXPECTED ERROR: Determine cause for available tech support \"{ex.Message}\""); 
            }
            count++;
        }
        Console.WriteLine();

    }//end of Main method
}//end of Program class