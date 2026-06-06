public class Parrot : Animal, IAdoptable, ITrainable
{

    public Parrot(string name, int age) : base(name, age, "Parrot")
    {

    }
    public override string MakeSound ()
    {
        return "\"What?\"";
    }

    public string GetAdoptionProfile ()
    {
        return "Name ".PadRight(11) + $"{Name}\n" + "Age ".PadRight(11) + $"{Age}\n" + "Species ".PadRight(11) + $"{Species}";
    }

    public string GetTrainingLevel ()
    {
        return "Basic (knows basic commands eat, quiet, sleep)";
    }
}