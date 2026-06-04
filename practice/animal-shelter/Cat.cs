public class Cat : Animal, IAdoptable
{

    public Cat(string name, int age) : base(name, age, "Cat")
    {

    }
    public override string MakeSound ()
    {
        return "meow";
    }

    public string GetAdoptionProfile ()
    {
        return "Name: ".PadRight(11) + $"{Name}\n" + "Age: ".PadRight(11) + $"{Age}\n" + "Species: " + $"{Species}";
    }

}