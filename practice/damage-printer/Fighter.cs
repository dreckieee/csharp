public class Fighter
{
    public string Name {get; private set;}
    public int Attack {get; private set;}
    public Fighter (string name, int attack)
    {
        Name = name;
        Attack = attack;
    }
}