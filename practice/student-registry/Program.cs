using System;

class Program
{
    static List <Student> students = new List<Student>();
    static void Main()
    {
        
        while(true)
        {
            Console.WriteLine("\n=================== STUDENT REGISTRY ===================");
            Console.WriteLine("1 -- Add a student (name, age, grade)");
            Console.WriteLine("2 -- Search for a student by name");
            Console.WriteLine("3 -- Display all students");
            Console.WriteLine("4 -- Display only students who are passing (grade >= 75)");
            Console.WriteLine("5 -- End Program\n");
            Console.Write("Choose a command (refer above): ");

            string? input = Console.ReadLine();
            if (input == "1")
            {
                AddAStudent();
                continue;
            }
            else if (input == "2")
            {
                SearchStudent();
                continue;
            }
            else if (input == "3")
            {
                DisplayStudents();
                continue;
            }
            else if (input == "4")
            {
                DisplayPassed();
                continue;
            }
            else if (input == "5")
            {
                Console.WriteLine("--Ending program...");
                break;
            }
            else 
            {
                Console.WriteLine("Invalid input. Choose from the option above.\n");
                continue;
            }

        }//end of menu loop
    }//end of Main ()


    public static void AddAStudent()
    {
        Console.WriteLine("\nEnter the following information to add a student to the registry: ");
        string name = ReadString("Name: ");
        int age = ReadInt("Age: ", 0);
        decimal grade = ReadDecimal("Grade: ",0,100);
        Student newStudent = new Student(name, age, grade);
        students.Add(newStudent);
        Console.WriteLine($"--You have successfully added {name} in the registry...\n");
    }//end of AddStudent method
    
    public static void SearchStudent ()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("\nThere are no students in the registry, Add a student first.\n");
        }
        else
        {
            string? input = ReadString("Enter the name of the student to find: ");
            Student? found = students.Find(f => f.Name == input);
            if (found == null)
            {
                Console.WriteLine("Student not found.");
            }
            else 
            {
                Console.WriteLine($"MATCH FOUND!");
                found.ShowInfo();
            }
        } 
    }//end of RemoveItem method




    public static void DisplayStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("\nThere are no students in the registry, Add a student first.\n");
        }
        else
        {
            int count = 1;
            Console.WriteLine("\n--Displaying students in the registry...");
            foreach (Student s in students)
            {
                Console.WriteLine($"• STUDENT#{count}");
                s.ShowInfo();
                Console.WriteLine(" ");
                count ++;
            }
            Console.WriteLine("--Done displaying students in the registry...\n");
        }


        
    }//end of DisplayStudents method


    public static void DisplayPassed()
    {
        Console.WriteLine("--Displaying Passed Students");
        List<Student> passingStudents = students.FindAll(s => s.Status == "Passed");
        if(passingStudents.Count == 0)
        {
            Console.WriteLine("\nThere are no students who passed in the registry.\n");
        }
        else
        {
            foreach(Student s in passingStudents)
            {
                s.ShowInfo();
                Console.WriteLine(" ");
            }
                Console.WriteLine(" ");
        }
    }

    //METHODS FOR CHECKING INPUTS
    public static int ReadInt(string prompt, int min)
    {
    int result = 0;
    bool valid = false;

        while (!valid)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid. No input provided.\n");
                continue;
            }
            if (!int.TryParse(input, out result))
            {
                Console.WriteLine("Invalid. Enter a positive integer.\n");
                continue;
            }

            if (result < min)
            {
                Console.WriteLine("Invalid. Enter a positive integer.\n");
                continue;
            }
            valid = true;
        }
        return result;
    }//end of "ReadInt" method

    public static decimal ReadDecimal(string prompt, decimal min, decimal max)
    {

        decimal decimalNum = 0;
        while(true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid. No input provided. Try again.\n");
                continue;
            }
            else if (!decimal.TryParse (input, out decimalNum))
            {
                Console.WriteLine("Invalid. Enter a decimal number. Try again.\n");
                continue;
            }
            if (decimalNum < min)
            {
                Console.WriteLine("Invalid. Enter a decimal number above 0. Try again.\n");
                continue;
            }
            if (decimalNum > max)
            {
                Console.WriteLine("Invalid. Enter a decimal number below 100. Try again.\n");
                continue;
            }

            break;
        }
        return decimalNum;
    }//end of ReadDecimal method


    public static string ReadString(string prompt)
    {
        string? stringInput = "";
        while(true)
        {
            Console.Write(prompt);
            stringInput = Console.ReadLine();

            if(string.IsNullOrEmpty(stringInput))
            {
                Console.WriteLine("Invalid. Enter a name\n");
                continue;
            }
            
            break;
        }
        return stringInput;
    }//end of ReadString


}//end of Program class
