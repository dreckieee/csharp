using System;

class Student
{

    public string? Name {get; set;}
    public int Age {get; set;}
    public decimal Grade {get; set;}
    public string? Status 
    {
        get
        {
            if (Grade >= 75) return "Passed";
            else return "Failed";
        }
    }


    public Student (string name, int age, decimal grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public void ShowInfo ()
    {
        Console.WriteLine($"NAME: {Name}");
        Console.WriteLine($"AGE: {Age}");
        Console.WriteLine($"GRADE: {Math.Round(Grade,2)}");
        Console.WriteLine($"STATUS: {Status}");
    }

}