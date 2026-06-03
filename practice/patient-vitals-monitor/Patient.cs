public class Patient
{
    public string Name {get; private set;}
    public int Age {get; private set;}
    public int MaxHP {get; private set;}
    public int HP 
    {
        get {return _hp;} 
        set {_hp = Math.Clamp(value, 0, MaxHP);}
    }
    private int _hp;
    public int BloodPressure {get; private set;}
    public int HeartRate {get; private set;}
    public Patient (string name, int age, int maxHP, int bloodPressure, int heartRate)
    {
        Name = name;
        Age = age;
        MaxHP = maxHP;
        HP = MaxHP;
        BloodPressure = bloodPressure;
        HeartRate = heartRate;
    }
    public void UpdateVitals (int newBloodPressure, int newHeartRate)
    {
        BloodPressure = newBloodPressure;
        HeartRate = newHeartRate;
    }
}