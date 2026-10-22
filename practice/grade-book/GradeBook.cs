namespace practice;

public class GradeBook
{
    private readonly Dictionary<string, Student> _students = new(StringComparer.OrdinalIgnoreCase);
    public void AddStudent(string name)
    {
        var student = new Student(name);
        if (_students.ContainsKey(student.Name))
        {
            throw new InvalidOperationException($"There is a student registered as \"{student.Name}\" already.");
        }
        _students.Add(student.Name, student);
    }

    public void AddGrade(string name, int grade)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name), "Student name cannot be null.");
        }
        if (!_students.TryGetValue(name.Trim(), out Student? student))
        {
            throw new KeyNotFoundException($"Failed to find any student named \"{name}\"");
        }
        student.AddGrade(grade);
    }

    public List<Student> GetRanking()
    {
        return _students.Values.Where(s => s.Grades.Count > 0).OrderByDescending(s => s.GetAverage()).ToList();
    }
}