public abstract class Animal
{
    public string Name {get; private set;}
    public int Age {get; private set;}
    public string Species {get; private set;}
    public Animal(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }
    public abstract void MakeSound();
}