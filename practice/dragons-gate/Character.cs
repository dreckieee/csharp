using System;

public abstract class Character
{
    public string Name {get; set;}
    public float MaxHP {get; set;}
    public float DefenseMultiplier {get; protected set;} = 1.0f;
    private float _hp;
    public float HP 
    {
        get{ return _hp;} 
        set{ _hp = Math.Clamp(value, 0, MaxHP);}
    }
    
    public Character (string name, float maxHP)
    {
        Name = name;
        MaxHP = maxHP;
        HP = maxHP;
    }
    public abstract void Attack(Character target);
}