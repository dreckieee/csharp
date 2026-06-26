public class Student
{
    public string Name {get; private set;}
    public List<string> EnrolledCourses {get; private set;}
    public Student (string name, List<string> enrolledCourses)
    {
        Name = name;
        EnrolledCourses = enrolledCourses;
    }
}