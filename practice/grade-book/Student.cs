namespace practice;

public class Student
{
    public string Name { get; }
    private const int MinimumGrade = 0;
    private const int MaximumGrade = 100;
    private readonly List<int> _grades = new();
    public IReadOnlyList<int> Grades => _grades;
    public Student(string name)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name), "Invalid student name (null). Provide a name for the student");
        }
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Invalid student name (empty or whitespace). Provide a name for the student", nameof(name));
        }
        name = name.Trim();
        Name = name;
    }
    public void AddGrade(int grade)
    {
        if (grade < MinimumGrade || grade > MaximumGrade)
        {
            throw new ArgumentOutOfRangeException(nameof(grade), grade, $"Invalid student grade. Provide a grade between '{MinimumGrade}' and '{MaximumGrade}'.");
        }
        _grades.Add(grade);
    }
    public double GetAverage()
    {
        if (_grades.Count == 0)
        {
            throw new InvalidOperationException("Failed to get student's average grade. Student has no added grade.");
        }
        return _grades.Average();
    }
}