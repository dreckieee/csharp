using System;

class GradeReportSystem
{//start of class Program

    static void Main()
    {//start of Main() method

        //ask user for the number of students (1 method used -- ReadInt)
        int numberOfStudents = ReadInt("\nHow many students: ", 1);
        Console.WriteLine();
    

        //ask user for the names of each student (2 methods used -- GetStudentNames, ReadString)
        string [] studentNames = GetStudentNames(numberOfStudents);
        Console.WriteLine();


        //Ask user for the 5 exam scores of each student (2 methods used -- GetExamScores, ReadDecimal)
        decimal [,] studentExamScores = GetExamScores(numberOfStudents);


        //calculate average scores of each student and their equivalent letter grade (2 methods used -- CalculateOverallScore)
        decimal [] studentsOverallScore = CalculateOverallScore(numberOfStudents, studentExamScores);


        //display grade report of each student (methods used -- DisplayGradeReport, GetEquivalentRating)
        Console.WriteLine("STUDENT   \tGRADE   \tRATING");
        DisplayGradeReport(numberOfStudents, studentNames, studentsOverallScore);


        //post-program somethings
        Console.Write("\nPress enter key to continue..");
        Console.ReadLine();
        Console.WriteLine();

    }//end of Main() method


    //start of method for getting names of students
    static string [] GetStudentNames(int numberOfStudents)
    {
        string [] studentNames = new string [numberOfStudents];
        for(int i = 0; i < numberOfStudents; i++)
        {
            studentNames[i] = ReadString($"Enter NAME of Student#{i+1}: ");
        }
        return studentNames;
    }//end of GetStudentNames method


    //start of method for asking user for students' exam scores
    static decimal[,] GetExamScores(int numberOfStudents)
    {
        decimal [,] studentExamScores = new decimal[numberOfStudents,5];
        for(int i = 0; i < numberOfStudents; i++)
        {
            for(int x = 0; x < 5; x++)
            {
                studentExamScores[i,x] = ReadDecimal($"Enter SCORE#{x+1} of Student#{i+1}: ",0,100);
            }
        Console.WriteLine();
        }
        return studentExamScores;
    }//end of "GetExamScores" method


    //start of method for calculating overall score
    static decimal [] CalculateOverallScore(int numberOfStudents, decimal [,] studentExamScores)
    {
        decimal [] overallScore = new decimal [numberOfStudents];
        for(int i = 0; i < numberOfStudents; i++)
        {
            for(int y = 0; y < 5; y++)
            {
                overallScore [i] += studentExamScores[i,y];
            }
            overallScore [i] /= 5.0m;
        }
        return overallScore;
    }//end of CalculateOverallScore method


    //start method for displaying grade report of each student
    static void DisplayGradeReport(int numberOfStudents, string [] studentNames, decimal [] studentsOverallScore)
    {
        for(int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"{studentNames[i]}:   \t{Math.Round(studentsOverallScore[i],2)}      \t{GetEquivalentRating(studentsOverallScore[i])}");
        }
    }//end of DisplayGradeReport method


    //start of method for getting equivalent rating of score
    static string GetEquivalentRating(decimal studentsOverallScore)
    {

        string rating = "Na";
        if      (studentsOverallScore >= 97) {rating = "A+";}
        else if (studentsOverallScore >= 93) {rating = "A";}
        else if (studentsOverallScore >= 90) {rating = "A-";}
        else if (studentsOverallScore >= 87) {rating = "B+";}
        else if (studentsOverallScore >= 83) {rating = "B";}
        else if (studentsOverallScore >= 80) {rating = "B-";}
        else if (studentsOverallScore >= 77) {rating = "C+";}
        else if (studentsOverallScore >= 73) {rating = "C";}
        else if (studentsOverallScore >= 70) {rating = "C-";}
        else if (studentsOverallScore >= 67) {rating = "D+";}
        else if (studentsOverallScore >= 63) {rating = "D";}
        else if (studentsOverallScore >= 60) {rating = "D-";}
        else if (studentsOverallScore >= 0) {rating = "F";}
        return rating;

    }//end of GetEquivalentRating method
    

    //start of method for validating int input
    static int ReadInt(string prompt, int min)
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


    //start of method for validating decimal input
    static decimal ReadDecimal(string prompt, decimal min, decimal max)
    {

        decimal x = 0;
        while(true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if      (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid. No input provided.\n");
                continue;
            }
            else if (!decimal.TryParse (input, out x))
            {
                Console.WriteLine("Invalid. Enter a positive number.\n");
                continue;
            }

            if      (x < min)
            {
                Console.WriteLine("Invalid. Enter a positive number.\n");
                continue;
            }
            if      (x > max)
            {
                Console.WriteLine("Invalid. Do not exceed 100.\n");
                continue;
            }
            break;
        }
        return x;

    }//end of ReadDecimal method


    //start of method for validating String input
    static string ReadString(string prompt)
    {
        string? x = "";
        while(true)
        {
            Console.Write(prompt);
            x = Console.ReadLine();

            if(string.IsNullOrEmpty(x))
            {
                Console.WriteLine("Invalid. Enter a name\n");
                continue;
            }
            
            break;
        }
        return x;

    }//end of ReadString
   




}//end of class Program





// initialize variables - graded assignments 
//int numberOfStudents = 0;
//string [] studentNames = new string[numberOfStudents];

/*
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
*/