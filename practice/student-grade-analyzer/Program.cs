using System;

class Program
{
    static void Main ()
    {
        var rng = new Random();
        var randomNames = new List<String>();
        var randomGrades = new List<Decimal>();
        var errorLogs = new List<String>();

        for (int x = 0; x < 30; x++)
        {
            randomGrades.Add( (decimal)rng.NextDouble() * 100m );
        }
        randomNames.Add("Dreck");
        randomNames.Add("Richard");
        randomNames.Add("Pascual");
        randomNames.Add("Lynn");
        randomNames.Add("Zergei");
        randomNames.Add("Pizarro");
        randomNames.Add("Jurado");
        randomNames.Add("Tabangay");
        randomNames.Add("Janet");
        randomNames.Add("Joseph");
        randomNames.Add("Tee Jay");
        randomNames.Add("Denden");
        randomNames.Add("Pandong");
        randomNames.Add("Kidlat");
        randomNames.Add("Kadena");
        randomNames.Add("Britney");
        randomNames.Add("Papi");
        randomNames.Add("Alien");
        randomNames.Add("Banban");
        randomNames.Add("Tiger");
        randomNames.Add("Meme");
        randomNames.Add("Eren");
        randomNames.Add("Mikasa");
        randomNames.Add("Armin");
        randomNames.Add("Tidus");
        randomNames.Add("Yuna");
        randomNames.Add("Cloud");
        randomNames.Add("Tifa");
        randomNames.Add("Sefiroth");
        randomNames.Add("Aeris");
        var studentRegistry = new List<Student>();
        for (int x = 0; x < 6; x++)
        {
            var student1 = new Student(randomNames [ rng.Next( 0, randomNames.Count ) ], randomGrades [ rng.Next( 0, randomGrades.Count ) ]);
            studentRegistry.Add(student1);
        }
        int count = 1;

        //ALL STUDENTS
        try
        {
            Console.WriteLine("\nAnalyzing ALL students...");
            DisplayAllStudents(studentRegistry);
        }
        catch (EmptyStudentListException ex)
        {
            Console.WriteLine($"EmptyStudentList Error: {ex.Message}");
            errorLogs.Add($"> {errorLogs.Count+1} EmptyStudentListException Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Analysis finished!\n");
            Console.WriteLine("==================================");
        }
        

        //PASSING STUDENTS
        try
        {
            Console.WriteLine("\nAnalyzing PASSING students...");
            List<Student> passingStudents = FilterPassedStudents(studentRegistry);
            Console.WriteLine("Displaying PASSING students...\n");
            count = 1;
            foreach(Student s in passingStudents)
            {
                Console.WriteLine($"> #{count}");
                Console.WriteLine($"Name: {s.Name}");
                Console.WriteLine($"Grade: {s.Grade:F2}\n");
                count++;
            }  
        }
        catch (EmptyStudentListException ex)
        {
            Console.WriteLine($"EmptyStudentList Error: {ex.Message}");
            errorLogs.Add($"> {errorLogs.Count+1} EmptyStudentListException Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Analysis finished!\n");
            Console.WriteLine("==================================");
        }


        //FAILING STUDENTS
        try
        {
            Console.WriteLine("\nAnalyzing FAILING students...");
            List<Student> failingStudents = FilterFailedStudents(studentRegistry);
            Console.WriteLine("Displaying FAILING students...\n");
            count = 1;
            foreach(Student s in failingStudents)
            {
                Console.WriteLine($"> #{count}");
                Console.WriteLine($"Name: {s.Name}");
                Console.WriteLine($"Grade: {s.Grade:F2}\n");
                count++;
            }
        }
        catch (EmptyStudentListException ex)
        {
            Console.WriteLine($"EmptyStudentList Error: {ex.Message}");
            errorLogs.Add($"> {errorLogs.Count+1} EmptyStudentListException Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Analysis finished!\n");
            Console.WriteLine("==================================");
        }


        //HIGHEST GRADE
        try
        {
            Console.WriteLine("\nAnalyzing student with the HIGHEST Grade...");
            Student highestGradeStudent = FilterHighestGradeStudent(studentRegistry);
            Console.WriteLine("Displaying student with the HIGHEST Grade...\n");
            Console.WriteLine($"Name: {highestGradeStudent.Name}");
            Console.WriteLine($"Grade: {highestGradeStudent.Grade:F2}\n");
        }
        catch (EmptyStudentListException ex)
        {
            Console.WriteLine($"EmptyStudentList Error: {ex.Message}");
            errorLogs.Add($"> {errorLogs.Count+1} EmptyStudentListException Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Analysis finished!\n");
            Console.WriteLine("==================================");
        }


        //LOWEST GRADE
        try
        {
            Console.WriteLine("\nAnalyzing student with the LOWEST Grade...");
            Student lowestGradeStudent = FilterLowestGradeStudent(studentRegistry);
            Console.WriteLine("Displaying student with the LOWEST Grade...\n");
            Console.WriteLine($"Name: {lowestGradeStudent.Name}");
            Console.WriteLine($"Grade: {lowestGradeStudent.Grade:F2}\n");
        }
        catch (EmptyStudentListException ex)
        {
            Console.WriteLine($"EmptyStudentList Error: {ex.Message}");
            errorLogs.Add($"> {errorLogs.Count+1} EmptyStudentListException Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Analysis finished!\n");
            Console.WriteLine("==================================");
        }
        

        //AVERAGE GRADE
        try
        {
            Console.WriteLine("\nAnalyzing AVERAGE grade of students...");
            decimal averageGrade = CalculateAverageGrade(studentRegistry);
            Console.WriteLine("Displaying AVERAGE grade of students...\n");
            Console.WriteLine($"> Average Grade of all the students: {averageGrade:F2}\n");
        }
        catch (EmptyStudentListException ex)
        {
            Console.WriteLine($"EmptyStudentList Error: {ex.Message}");
            errorLogs.Add($"> {errorLogs.Count+1} EmptyStudentListException Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Analysis finished!\n");
            Console.WriteLine("==================================");
        }


        

    }//end of Main method

    static List<Student> FilterPassedStudents (List<Student> studentRegistry)
    {
        if (studentRegistry.Count == 0)
        {
            throw new EmptyStudentListException("Student Registry is empty. Unable to filter PASSING students.");
        }
        List <Student> filter = studentRegistry.FindAll(s => s.Grade >= 60);
        if (filter.Count == 0)
        {
            throw new EmptyStudentListException("All students have FAILING grades.");
        }
        return filter;
    }

    static List<Student> FilterFailedStudents (List<Student> studentRegistry)
    {
        if (studentRegistry.Count == 0)
        {
            throw new EmptyStudentListException("Student Registry is empty. Unable to filter FAILING students.");
        }
        List<Student> filter = studentRegistry.FindAll(s => s.Grade < 60);
        if (filter.Count == 0)
        {
            throw new EmptyStudentListException("All students have PASSING grades.");
        }
        return filter;
    }

    static Student FilterHighestGradeStudent (List<Student> studentRegistry)
    {
        if (studentRegistry.Count == 0)
        {
            throw new EmptyStudentListException("Student Registry is empty. Unable to determine student with the HIGHEST GRADE.");
        }
        Student highest = studentRegistry.MaxBy(s => s.Grade)!;
        return highest;
    }


    static Student FilterLowestGradeStudent (List<Student> studentRegistry)
    {
        if (studentRegistry.Count == 0)
        {
            throw new EmptyStudentListException("Student Registry is empty. Unable to determine student with the LOWEST GRADE.");
        }
        Student lowest = studentRegistry.MinBy(s => s.Grade)!;
        return lowest;
    }


    static Decimal CalculateAverageGrade (List<Student> studentRegistry)
    {
        if (studentRegistry.Count == 0)
        {
            throw new EmptyStudentListException("Student Registry is empty. Unable to calculate AVERAGE GRADE of students.");
        }
        decimal average = studentRegistry.Average(s => s.Grade);
        return average;
    }

    static void DisplayAllStudents (List<Student> studentRegistry)
    {
        if (studentRegistry.Count == 0)
        {
            throw new EmptyStudentListException("Student Registry is empty. Unable to display ALL students.");
        }
        Console.WriteLine("Displaying ALL students...\n");
        int count = 1;
        foreach(Student s in studentRegistry)
        {
            Console.WriteLine($"> #{count}");
            Console.WriteLine($"Name: {s.Name}");
            Console.WriteLine($"Grade: {s.Grade:F2}\n");
            count++;
        }
        Console.WriteLine("==================================");
    }

}//end of Program class