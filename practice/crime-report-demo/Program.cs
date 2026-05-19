using System;

class Program
{
    static void Main()
    {
        List<Suspect> suspects = new List<Suspect>();
        Criminal criminal1 = new Criminal("Dreck", 30, SuspectStatus.UnderInvestigation, "21 years of imprisonment");
        Criminal criminal2 = new Criminal("Richard", 40, SuspectStatus.Arrested, "Death Sentence");
        Witness witness1 = new Witness("Lynn", 10, SuspectStatus.Cleared, "I saw Dreck killed a dog");
        Witness witness2 = new Witness("Zergei", 20, SuspectStatus.Cleared, "I saw Richard create a bomb");
        Civilian civilian1 = new Civilian("Rust", 50, SuspectStatus.Cleared);
        suspects.Add(criminal1);
        suspects.Add(witness1);
        suspects.Add(criminal2);
        suspects.Add(witness2);
        suspects.Add(civilian1);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("╔══════════════════════════════════════╗");
        Console.WriteLine("║               C R I M E              ║");
        Console.WriteLine("║              R E P O R T             ║");
        Console.WriteLine("╚══════════════════════════════════════╝");
        Console.ResetColor();

        foreach(Suspect s in suspects)
        {
            s.GetInfo();
        }
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n═══ CHARGES & TESTIMONIES ═══");
        Console.ResetColor();
        foreach(Suspect s in suspects)
        {
            if (s is ICriminal criminal) {criminal.GetCharges();}
            else if (s is IWitness witness) {witness.GetTestimony();}
        }
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n═══════════════  E N D   O F   R E P O R T  ═══════════════");
        Console.ResetColor();
        Console.Write("Press enter key to continue..");
        Console.ReadLine();


    }//end of Main method
}//end of Program class