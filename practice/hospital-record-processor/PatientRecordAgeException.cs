public class PatientRecordAgeException : PatientRecordException
{
    public int Age {get; private set;}
    public PatientRecordAgeException (string message, int age) : base (message)
    {
        Age = age;
    }
}