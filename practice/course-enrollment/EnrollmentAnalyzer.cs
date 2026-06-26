public static class EnrollmentAnalyzer
{
    public static void PrintAllEnrollment (List<Student> students)
    {
        Console.WriteLine("> Displaying All Enrollments...");
        var allEnrollment = students.SelectMany (s => s.EnrolledCourses, (s, course) => new {s.Name, course});
        foreach (var s in allEnrollment)
        {
            Console.WriteLine($"{s.Name} - {s.course}" );
        }
        Console.WriteLine();
    }
    public static void PrintUniqueCourses (List<Student> students)
    {
        Console.WriteLine("> Displaying Unique Courses...");
        List<string> uniqueCourses = students.SelectMany(s => s.EnrolledCourses).Distinct().OrderBy(s => s).ToList();
        for (int x = 0; x < uniqueCourses.Count; x++)
        {
            Console.WriteLine($"{x+1}. {uniqueCourses[x]}");
        }
        Console.WriteLine();
    }
}