public class PatientRecord
{
    public string Name {get; private set;}
    public int Age {get; private set;}
    public DiagnosisCode Diagnosis {get; private set;}
    public PatientRecord (string name, int age, DiagnosisCode diagnosis)
    {
        Name = name;
        Age = age;
        Diagnosis = diagnosis;
    }
    
}