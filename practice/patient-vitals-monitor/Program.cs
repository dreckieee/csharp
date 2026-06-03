using System;

class Program
{
    private static Random rng = new Random();
    static void Main ()
    {
        Console.WriteLine("\nWelcome, dreckieee!\n");

        
        GenerateVitals (out int bp, out int hr);
        var patient1 = new Patient ("Dreck Richard Pascual", 32, bp, hr);
        EvaluateStatus(patient1.BloodPressure, patient1.HeartRate, out string status);
        Console.WriteLine($"> Patient #1");
        Console.WriteLine("Name: ".PadRight(20) + $"{patient1.Name}");
        Console.WriteLine("Age: ".PadRight(20) + $"{patient1.Age}");
        Console.WriteLine("Blood Pressure: ".PadRight(20) + $"{patient1.BloodPressure}");
        Console.WriteLine("Heart Rate: ".PadRight(20) + $"{patient1.HeartRate}");
        Console.WriteLine("Status: ".PadRight(20) + $"{status}\n");

        if (status == "Critical" || status == "Unstable") 
        {
            RecordVitals("Blood Pressure", patient1.BloodPressure, "mmHg");
            RecordVitals("Heart Rate", patient1.HeartRate, "bpm");
            Console.WriteLine($"\n> Patient {patient1.Name} is in {status} condition! Administering meds...");
            AdministerMeds(ref bp, ref hr, 10, 5);
            patient1.UpdateVitals(bp, hr);
            Console.WriteLine("> Updating patient's vitals..\n");
            RecordVitals("Blood Pressure", patient1.BloodPressure, "mmHg");
            RecordVitals("Heart Rate", patient1.HeartRate, "bpm");
            EvaluateStatus(patient1.BloodPressure, patient1.HeartRate, out string newStatus);
            Console.WriteLine("Status: ".PadRight(20) + $"{newStatus}\n");

            if (newStatus == "Critical" || newStatus == "Unstable")
            {
                Console.WriteLine($"\n> Patient {patient1.Name} is still in {status} condition! Administering meds...");          
                AdministerMeds(ref bp, ref hr, 4, 2);
                patient1.UpdateVitals(bp, hr);
                Console.WriteLine("> Updating patient's vitals..\n");
                RecordVitals("Blood Pressure", patient1.BloodPressure);
                RecordVitals("Heart Rate", patient1.HeartRate);

                EvaluateStatus(patient1.BloodPressure, patient1.HeartRate, out string finalStatus);
                RecordVitals("Status", finalStatus);
            }

        }
        else
        {
            Console.WriteLine($"\n> Patient's vitals is {status}. Displaying vitals...");
            RecordVitals("Blood Pressure", patient1.BloodPressure, "mmHg");
            RecordVitals("Heart Rate", patient1.HeartRate, "bpm");
        }

        

    }//end of Main method

    static void GenerateVitals (out int bloodPressure, out int heartRate)
    {
        bloodPressure = rng.Next(60, 141);
        heartRate = rng.Next(50, 110);
    }

    static void EvaluateStatus (int bloodPressure, int heartRate, out string status)
    {
        if (bloodPressure < 70 || bloodPressure > 130 || heartRate < 55 || heartRate > 105) {status = "Critical";}
        else if (bloodPressure < 80 || bloodPressure > 119 || heartRate < 60 || heartRate > 99) {status = "Unstable";}
        else if (bloodPressure < 90 || bloodPressure > 109 || heartRate < 65 || heartRate > 94) {status = "Stable";}
        else {status = "Healthy";}
    }

    static void AdministerMeds (ref int bloodPressure, ref int heartRate, int bpChange = 10, int hrChange = 5)
    {
        if (bloodPressure < 90) {bloodPressure = Math.Clamp(bloodPressure + bpChange, 0, int.MaxValue);}
        else if (bloodPressure > 109) {bloodPressure = Math.Clamp(bloodPressure - bpChange, 0, int.MaxValue);}
        if (heartRate < 65) {heartRate = Math.Clamp(heartRate + hrChange, 0, int.MaxValue);}
        else if (heartRate > 94) {heartRate = Math.Clamp(heartRate - hrChange, 0, int.MaxValue);}
    }

    static void RecordVitals (string label, int value)
    {
        Console.WriteLine($"{label}: ".PadRight(20) + $"{value}");
    }

    static void RecordVitals (string label, int value, string unit)
    {
        Console.WriteLine($"{label}: ".PadRight(20) + $"{value}".PadRight(5) + $"{unit}");
    }

    static void RecordVitals (string label, string value)
    {
        Console.WriteLine($"{label}: ".PadRight(20) + $"{value}");
    }
}//end of Program class