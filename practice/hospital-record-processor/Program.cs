class Program
{
    static void Main ()
    {
        var recordValidator = new PatientRecordValidator();
        var errors = new List<string>();
        var patientsRecords = new List<PatientRecord>();
        

        var patientRecord = new PatientRecord("Dreck", 50, DiagnosisCode.Diagnosis002);
        patientsRecords.Add(patientRecord);

        patientRecord = new PatientRecord("Richard", -10, DiagnosisCode.Diagnosis002);
        patientsRecords.Add(patientRecord);

        patientRecord = new PatientRecord("Pascual", -1, DiagnosisCode.Diagnosis004);
        patientsRecords.Add(patientRecord);

        patientRecord = new PatientRecord("Lynn", 47, DiagnosisCode.Unknown);
        patientsRecords.Add(patientRecord);

        patientRecord = new PatientRecord("Zergei", 147, DiagnosisCode.Diagnosis003);
        patientsRecords.Add(patientRecord);

        int count = 1;
        Console.WriteLine("CHECKING PATIENT RECORDS...");
        foreach (PatientRecord record in patientsRecords)
        {
            Console.WriteLine($"> {count} -- Checking Patient Record of \"{record.Name}\"");

            //check age
            try
            {
                recordValidator.CheckRecordAge(record);
            }
            catch (PatientRecordAgeException ex) when (ex.Age < 0)
            {
                errors.Add($"Patient \"{record.Name}\" {ex.Message}Patient Age with negative value ({ex.Age}).");   
                Console.WriteLine($"{ex.Message}Age cannot be negative ({ex.Age}), request for revision is submitted."); 
            }
            catch (PatientRecordAgeException ex) when (ex.Age > 140)
            {
                errors.Add($"Patient \"{record.Name}\" {ex.Message}Patient Age with high value ({ex.Age}).");   
                Console.WriteLine($"{ex.Message}Age is too high ({ex.Age}), request for revision is submitted."); 
            }
            catch (PatientRecordException ex)
            {
                errors.Add($"Patient \"{record.Name}\" {ex.Message} Unexpected Invalid Age Error");
                Console.WriteLine($"{ex.Message} Unexpected Invalid Age Error");
            }

            //check diagnosis
            try
            {
                recordValidator.CheckRecordDiagnosis(record);
            }
            catch (PatientRecordDiagnosisException ex) when (ex.Diagnosis == DiagnosisCode.Unknown)
            {
                errors.Add($"Patient \"{record.Name}\" " +ex.Message + $"UNKNOWN DIAGNOSIS: Unable to confirm complete diagnosis.");
                Console.WriteLine(ex.Message + $"UNKNOWN DIAGNOSIS: Determine correct diagnosis as soon as possible, request for assessing is submitted.");
            }   
            catch (PatientRecordDiagnosisException ex) when (ex.Diagnosis == DiagnosisCode.Diagnosis003)
            {
                errors.Add($"Patient \"{record.Name}\" "+ex.Message + $"CRITICAL DIAGNOSIS: Immediate attention is required!");
                Console.WriteLine(ex.Message + $"CRITICAL DIAGNOSIS: Immediate attention is required! forwarded record to emergency team.");
            }
            catch (PatientRecordDiagnosisException ex) when (ex.Diagnosis == DiagnosisCode.Diagnosis004)
            {
                errors.Add($"Patient \"{record.Name}\" "+ex.Message + $"EMERGENCY: PATIENT NEEDS TOP PRIORITY!");
                Console.WriteLine(ex.Message + $"EMERGENCY: PATIENT NEEDS TOP PRIORITY! ON-CALL DOCTOR IS CONTACTED!");
            }
            catch (PatientRecordException ex)
            {
                errors.Add($"Patient \"{record.Name}\" {ex.Message} Unexpected Invalid Diagnosis Error");
                Console.WriteLine($"{ex.Message} Unexpected Invalid Diagnosis Error");
            }
            finally
            {
                count++;
                Console.WriteLine($"Finished checking patient record of \"{record.Name}\"");
                Console.WriteLine();
            }
        }


        count = 1;
        if (errors.Count > 0)
        {
            Console.WriteLine("DISPLAYING FLAGGED ERRORS...");
            foreach (string error in errors)
            {
                Console.WriteLine($"> {count}. {error}");
                count++;
            }
        }
        
        

    }//end of Main method

}//end of Program class