public static class RosterAnalyzer
{
    public static void PrintGroupedRoster (List<Student> students)
    {
        
        Console.WriteLine("\n> Displaying students by GRADE LEVEL...");
        var grouped = students.GroupBy(s => s.Level).OrderBy(s => s.Key);
        foreach (var group in grouped)
        {
            Console.WriteLine($"\tGrade {(int)group.Key}");
            foreach (var s in group)
            {
                Console.WriteLine($"\t- " + $"{s.Name}".PadRight(13) + $"GWA: {s.GWA:F2}");
            }
            Console.WriteLine($"\t-- Students: {group.Count()}  |  Average GWA: {group.Average(s => s.GWA):F2}\n");
        }
    }

}