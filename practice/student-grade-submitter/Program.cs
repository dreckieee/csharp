using System;

class Program
{
    static void Main ()
    {
        Console.WriteLine("\nWelcome, dreckieee!\n");
        string studentNamePrompt = "Enter the STUDENT'S NAME: ";
        string studentGradePrompt = "Enter the STUDENT'S GRADE: ";
        var students = new List<Student>();
        var logs = new List<String>();

        int loopCount = ReadIntNoMax("Enter how many students you are going to register: ", 0);

        for (int x = 0; x < loopCount; x++)
        {
            try
            {
                string studentName = ReadStudentName(studentNamePrompt);
                decimal studentGrade = ReadStudentGrade(studentGradePrompt, 0m, 100m);  
                var student1 = new Student(studentName, studentGrade);
                students.Add(student1);
                Console.WriteLine($"Successfully registered \"{student1.Name}\"");          
            }
            catch (InvalidStudentNameException ex)
            {
                logs.Add($"[LOG] InvalidStudentNameException Error: {ex.Message}");
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InvalidStudentGradeException ex)
            {
                logs.Add($"[LOG] InvalidStudentGradeException Error: {ex.Message}");
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                logs.Add($"[LOG] Unexpected Error: {ex.Message}");
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Registration attempt #{x+1} complete.");
                if (students.Count > 0)
                {
                    PrintStudents(students);
                }
                if (logs.Count > 0)
                {
                    PrintErrorLogs(logs);
                }
            }
        }// end of loop
    }//end of Main method


    public static decimal ReadStudentGrade(string prompt, decimal min, decimal max)
    {
        Console.Write(prompt);
        if (decimal.TryParse(Console.ReadLine(), out decimal result))
        {
            if (result >= min && result <= max)
            {
                return result;
            }
            throw new InvalidStudentGradeException($"Grade must be between {min} and {max}. Try again.");
        }
        else
        {
            throw new InvalidStudentGradeException("Not a decimal number. Try again.");    
        }
    }//end of ReadGrade method

    public static string ReadStudentName(string prompt)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new InvalidStudentNameException("Name cannot be empty. Try again.");
        }
        else
        {
            return input;
        }
    }//end of ReadString method

    public static void PrintStudents (List<Student> students)
    {
        Console.WriteLine($"\n==================== STUDENTS ====================\n");
        foreach (Student student in students)
        {
            Console.WriteLine ("NAME: ".PadRight(10) + $"{student.Name}");
            Console.WriteLine ("GRADE: ".PadRight(10) + $"{student.Grade:F2}\n");
        }
        Console.WriteLine($"==================================================\n");
    }//end of PrintStudents method

    public static void PrintErrorLogs (List<string> logs)
    {
        int count = 1;
        Console.WriteLine($"\n==================== ERROR LOGS ====================\n");
        foreach (string log in logs)
        {
            Console.WriteLine ($"> {count} -- " + log);
            count ++;
        }
        Console.WriteLine($"\n====================================================\n");
    }//end of PrintStudents method


    public static int ReadIntNoMax(string prompt, int min)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                if (result >= min)
                {
                    return result;
                }
                Console.WriteLine($"Must be at least {min}. Try again.");
            }
            else
            {
                Console.WriteLine("Enter an integer. Try again.");
            }
        }
    }//end of ReadIntNoMax method  

}//end of Program class