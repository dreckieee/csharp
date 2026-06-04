public class Dog : Animal, IAdoptable, ITrainable
{

    public Dog(string name, int age) : base(name, age, "Dog")
    {

    }
    public override string MakeSound ()
    {
        return "woof!";
    }

    public string GetAdoptionProfile ()
    {
        return "Name: ".PadRight(11) + $"{Name}\n" + "Age: ".PadRight(11) + $"{Age}\n" + "Species: " + $"{Species}";
    }

    public string GetTrainingLevel ()
    {
        return "Level: Advanced - knows basic commands (sit, stay, etc.) and advanced commands (roll, play dead, etc.)";
    }
}