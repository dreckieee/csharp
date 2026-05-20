using System;

class Program
{
    static void Main()
    {
        List<Ticket> tickets = new List<Ticket>();
        BugReport bugReport1 = new BugReport("Right arm Bug", TicketPriority.Low, "1 -- Walk to a just before a high platform\n2 -- jump and use right arm\n3 -- Character gets stuck");
        FeatureRequest featureRequest1 = new FeatureRequest ("Shooting Interface", TicketPriority.Medium, "Dreck", "Requesting an interface for shooting while in bullet time");
        CrashReport crashReport1 = new CrashReport ("Signup freeze", TicketPriority.High, "CV98321", "Error when click signup on login interface");

        tickets.Add(bugReport1);
        tickets.Add(featureRequest1);
        tickets.Add(crashReport1);

        Console.WriteLine("\n========== ALL TICKETS ==========");
        int iteration = 1;
        foreach (Ticket t in tickets)
        {
            Console.WriteLine($"\nTICKET #{iteration}");
            t.GetDetails();
            iteration ++;
        }

        Console.WriteLine("\n========== TICKET ACTIONS ==========");
        iteration = 1;
        foreach (Ticket t in tickets)
        {
            if (t is IBugReport bugReport)
            {
                Console.WriteLine("\n>> Bug Report");
                bugReport.Reproduce();
            }
            else if (t is IFeatureRequest featureRequest)
            {
                Console.WriteLine("\n>> Feature Request");
                featureRequest.SubmitRequest();
            }
            else if (t is ICrashReport crashReport)
            {
                Console.WriteLine("\n>> Crash Report");
                crashReport.ReportError();
            }
            iteration ++;
        }

        Console.Write("\n\nPress Enter key to continue...");
        Console.ReadLine();
    }//end of Main method
}//end of Program class