public abstract class Suspect
{
    public string Name {get; set;}
    public int Age {get; set;}
    public SuspectStatus Status {get; set;}
    public Suspect (string name, int age, SuspectStatus status)
    {
        Name = name;
        Age = age;
        Status = status;
    }

    public abstract void GetInfo();
}