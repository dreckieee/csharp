public class Patient
{
    public string Name {get; private set;}
    public int Age {get; private set;}
    public int BloodPressure {get; private set;}
    public int HeartRate {get; private set;}
    public Patient (string name, int age, int bloodPressure, int heartRate)
    {
        Name = name;
        Age = age;
        BloodPressure = bloodPressure;
        HeartRate = heartRate;
    }
    public void UpdateVitals (int newBloodPressure, int newHeartRate)
    {
        BloodPressure = newBloodPressure;
        HeartRate = newHeartRate;
    }
}