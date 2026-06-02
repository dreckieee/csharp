public class Character
{
    public string Name {get; private set;}
    public int MaxHP {get; private set;}
    private int _hp;
    public int HP 
    {
        get {return _hp;}
        set {_hp = Math.Clamp(value, 0, MaxHP);}
    }    
    public int Attack {get; set;}
    public Character (string name, int maxHP, int attack)
    {
        Name = name;
        MaxHP = maxHP;
        HP = MaxHP;
        Attack = attack;
    }
}