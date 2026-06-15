public class PatientRecordDiagnosisException : PatientRecordException
{
    public DiagnosisCode Diagnosis {get; private set;}
    public PatientRecordDiagnosisException (string message, DiagnosisCode diagnosis) : base (message)
    {
        Diagnosis = diagnosis;
    }
}