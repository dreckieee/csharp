class Program
{
    static void Main ()
    {
        var students = new List<Student>
        {
            new Student ("Dreck", new List<string> { "Math", "Science", "English" }),
            new Student ("Lynn", new List<string> { "TLE", "English", "MAPEH" }),
            new Student ("Richard", new List<string> { "Filipino", "Math", "English" }),
            new Student ("Zergei", new List<string> { "Math", "Filipino", "English" }),
            new Student ("Liora", new List<string> { "Science", "MAPEH", "Math" })
        };

        EnrollmentAnalyzer.PrintAllEnrollment(students);
        EnrollmentAnalyzer.PrintUniqueCourses(students);
    }//end of Main method
}//end of Program class