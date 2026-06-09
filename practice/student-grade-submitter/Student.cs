public class Student
{
    public string Name {get; private set;}
    public decimal Grade {get; private set;}
    public Student (string name, decimal grade)
    {
        Name = name;
        Grade = grade;
    }
}