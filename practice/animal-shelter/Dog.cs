public class Dog : Animal, IAdoptable, ITrainable
{

    public Dog(string name, int age) : base(name, age, "Dog")
    {

    }
    public override string MakeSound ()
    {
        return "\"woof!\"";
    }

    public string GetAdoptionProfile ()
    {
        return "Name ".PadRight(11) + $"{Name}\n" + "Age ".PadRight(11) + $"{Age}\n" + "Species ".PadRight(11) + $"{Species}";
    }

    public string GetTrainingLevel ()
    {
        return "Advanced (knows basic commands like sit, stay, etc. and advanced commands as well such as roll, play dead, etc.)";
    }
}