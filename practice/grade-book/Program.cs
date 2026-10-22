namespace practice;
class Program
{
    static void Main()
    {
        var gradeBook = new GradeBook();
        while (true)
        {
            Console.WriteLine("1 -- Add a student");
            Console.WriteLine("2 -- Add grade of student");
            Console.WriteLine("3 -- show ranking");
            Console.WriteLine("4 -- Exit\n");
            string prompt = "Enter a command: ";
            int command = ReadInt(prompt);
            if (command == 1)
            {
                AddStudent(gradeBook);
            }
            else if (command == 2)
            {
                AddGrade(gradeBook);
            }
            else if (command == 3)
            {
                ShowRanking(gradeBook);
            }
            else if (command == 4)
            {
                Exit();
                break;
            }
            else
            {
                Console.WriteLine("Invalid command (refer above).");
            }
        }
    }

    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid. Enter an integer number. Try again.");
            }
        }
    }

    private static string ReadString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Cannot be empty. Try again.");
            }
            else
            {
                return input;
            }
        }
    }

    private static void AddStudent(GradeBook gradeBook)
    {
        string namePrompt = "\nEnter the name of the new student: ";
        string input = ReadString(namePrompt);
        try
        {
            gradeBook.AddStudent(input);
            Console.WriteLine("\nSuccessfully added a student!\n");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
    }

    private static void AddGrade(GradeBook gradeBook)
    {
        string gradePrompt1 = "\nEnter the name of the student whose grade you want to add: ";
        string studentName = ReadString(gradePrompt1);

        string gradePrompt2 = "Enter the grade of the student: ";
        int grade = ReadInt(gradePrompt2);

        try
        {
            gradeBook.AddGrade(studentName, grade);
            Console.WriteLine("\nSuccessfully added the grade of a student!\n");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
    }

    private static void ShowRanking(GradeBook gradeBook)
    {
        var ranked = gradeBook.GetRanking();
        if (ranked.Count == 0)
        {
            Console.WriteLine("\nNothing to rank. There are no existing grades for any students.\n");
            return;
        }
        Console.WriteLine("\n--Ranking of students based on average grade--");
        int counter = 1;
        foreach (Student student in ranked)
        {
            Console.WriteLine($"{counter} -- Name: {student.Name} | Grade: {student.GetAverage():F2}");
            counter++;
        }
        Console.WriteLine();
    }

    private static void Exit()
    {
        Console.WriteLine("\nYou have chosen \"EXIT PROGRAM\"!");
        Console.WriteLine("Closing program...");
        Console.Write("Press enter key to continue..");
        Console.ReadLine();
    }
}