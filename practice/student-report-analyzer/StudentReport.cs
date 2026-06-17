public class StudentReport
{
    public string Name {get; private set;}
    public double Grade {get; private set;}
    public string Subject {get; private set;}
    public StudentReport (string name, double grade, string subject)
    {
        Name = name;
        Grade = grade;
        Subject = subject;
    }
}