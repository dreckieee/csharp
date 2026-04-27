using System;
class dreckieeeGradeCalculator
{
    static void Main()
    {
        //user input on how many subjects
        Console.Write("How many subjects you have: ");
        int subjectsNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nEnter the grades of those {subjectsNum} subjects");
        //declare grade variable and rating
        decimal grade = 0;
        string gradeRating = "Na";
        int gradeTemp = 0; //temporary variable to store grade on each subject
        //loop for user input on grades of each subject
        for(int i = 0;i < subjectsNum; i++)
        {
            i += 1;
            Console.Write($"Subject {i}: ");
            gradeTemp = Convert.ToInt32(Console.ReadLine());
            grade = grade + gradeTemp;
            i -= 1;
        }
        //computation for grade average
        grade = (decimal)grade / subjectsNum; 
        //conditional statements for equivalent rating
        if(grade>=90){gradeRating = "EXCELLENT";}
        else if(grade>=80){gradeRating = "GOOD";}
        else if(grade>=70){gradeRating = "SATISFACTORY";}
        else if(grade>=60){gradeRating = "PASSING";}
        else if(grade<60){gradeRating = "FAILED";}
        Console.WriteLine($"\nYour Grade is: {Math.Round(grade,2)} with a rating of {gradeRating}!");
        //I rounded to two decimal places using F2 
    }
}


