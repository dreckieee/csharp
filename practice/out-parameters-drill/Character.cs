public class Character
{
    public string Name {get; private set;}
    public int HP {get; private set;}
    public int Attack {get; private set;}
    public int Defense {get; private set;}
    public string Rank {get; private set;}
    public Character (string name, int hp, int attack, int defense, string rank)
    {
        Name = name;
        HP = hp;
        Attack = attack;
        Defense = defense;
        Rank = rank;
    }
}