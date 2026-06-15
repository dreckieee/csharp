public class PatientRecordValidator
{
    public void CheckRecordAge (PatientRecord record)
    {
            if (record.Age < 0 || record.Age > 140)
            {
                throw new PatientRecordAgeException ($"INVALID PATIENT AGE detected. ", record.Age);
            }
    }
    public void CheckRecordDiagnosis (PatientRecord record)
    {
        if (record.Diagnosis == DiagnosisCode.Unknown || record.Diagnosis == DiagnosisCode.Diagnosis003 || record.Diagnosis == DiagnosisCode.Diagnosis004)
        {
            throw new PatientRecordDiagnosisException ($"DIAGNOSIS \"{record.Diagnosis}\" detected. ", record.Diagnosis);
        }
    }
}