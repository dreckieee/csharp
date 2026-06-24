public class Student
{
    public string Name {get; private set;}
    public GradeLevel Level {get; private set;}
    public double GWA {get; private set;}
    public Student (string name, GradeLevel level, double gwa)
    {
        Name = name;
        Level = level;
        GWA = gwa;
    }
}