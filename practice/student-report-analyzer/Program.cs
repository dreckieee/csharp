class Program
{
    static void Main ()
    {

        var subjects = new List<string>{"Math", "English", "Science"};
        var names = new List<string> {"Dreck", "Richard", "Jurado", "Pascual", "Lynn", "Zergei", "Tabangay", "Pizarro"};

        var rng = new Random();
        var filter = new List<StudentReport>();
        int count;

        //adding StudentReport objects to List<StudentReport>
        var students = new List<StudentReport>();
        foreach (string s in subjects)
        {
            foreach (string ss in names)
            {
                var student = new StudentReport(ss, 50 + (rng.NextDouble() * 50), s);
                students.Add(student);
            }
        }

        //students who passed in each subject
        foreach (string subject in subjects)
        {
            Console.WriteLine($"\n> Displaying students who PASSED the {subject.ToUpper()} subject...");
            count = 1;
            filter = students.FindAll(s => s.Subject == subject && s.Grade >= 75);
            if (filter.Count > 0)
            {
                foreach (StudentReport sr in filter)
                {
                    Console.WriteLine($"{count}".PadRight(3) + "-- " + $"{sr.Name}".PadRight(9) + $"({sr.Grade:F2})");
                    count++;
                }
            }
            else
            {
                Console.WriteLine($"--NO ONE PASSED the {subject.ToUpper()} subject!");
            }
        }


        //top students in each subject
        Console.WriteLine("\n> Displaying TOP STUDENTS in each subject...");
        StudentReport? topStudent;
        foreach (string subject in subjects)
        {
            topStudent = students.Where(s => s.Subject == subject).MaxBy(s => s.Grade);
            Console.WriteLine($"{subject}".PadRight(8) + "-- " + $"{topStudent!.Name}".PadRight(9) + $"({topStudent.Grade:F2})");
        }


        //average of all students in each subject
        Console.WriteLine("\n> Displaying AVERAGE OF ALL STUDENTS in each subject...");
        double average;
        foreach (string subject in subjects)
        {
            average = students.Where(s => s.Subject == subject).Average(s => s.Grade);
            Console.WriteLine($"{subject}".PadRight(8) + "-- " + $"{average:F2}");
        }


        //descending order by grades in each subject
        Console.WriteLine("\n> Displaying students in DESCENDING ORDER of grades in each subject...");
        foreach (string subject in subjects)
        {
            count = 1;
            filter = students.Where(s => s.Subject == subject).OrderByDescending(s => s.Grade).ToList();
            Console.WriteLine($">>> {subject}");
            foreach (StudentReport sr in filter)
            {
                Console.WriteLine($"{count}".PadLeft(7) + ". " + $"{sr.Name}".PadRight(9) + $"({sr.Grade:F2})");
                count++;
            }
            Console.WriteLine();
        }
        
    }//end of Main method
}//end of Program class