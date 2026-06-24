class Program
{
    static Random rng = new ();
    static void Main ()
    {
        double minGWA = 1.0;
        double maxGWA = 5.0;
        
        var student1 = new Student("Dreck", GradeLevel.Grade10, RandomGWA(minGWA, maxGWA));
        var student2 = new Student("Richard", GradeLevel.Grade11, RandomGWA(minGWA, maxGWA));
        var student3 = new Student("Pascual", GradeLevel.Grade12, RandomGWA(minGWA, maxGWA));
        var student4 = new Student("Lynn", GradeLevel.Grade10, RandomGWA(minGWA, maxGWA));
        var student5 = new Student("Zergei", GradeLevel.Grade11, RandomGWA(minGWA, maxGWA));
        var student6 = new Student("Pizarro", GradeLevel.Grade12, RandomGWA(minGWA, maxGWA));
        var student7 = new Student("Tabangay", GradeLevel.Grade12, RandomGWA(minGWA, maxGWA));
        var student8 = new Student("Jurado", GradeLevel.Grade11, RandomGWA(minGWA, maxGWA));
        var student9 = new Student("Betty", GradeLevel.Grade10, RandomGWA(minGWA, maxGWA));

        List<Student> students = new List<Student> 
        {student1, student2, student3, student4,
        student5, student6, student7, student8, student9};

        RosterAnalyzer.PrintGroupedRoster(students);
    }//end of Main method

    static double RandomGWA (double minGWA, double maxGWA)
    {
        return minGWA + ( rng.NextDouble() * (maxGWA - minGWA) );
    }
}//end of Program class