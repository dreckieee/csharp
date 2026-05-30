using System;

public abstract class Character
{
    public string Name {get; set;}
    public float MaxHP {get; set;}
    private float _hp;
    public float HP 
    {
        get{ return _hp;} 
        set{ _hp = Math.Clamp(value, 0, MaxHP);}
    }

    public float Attack {get; set;}
    public float Defense {get; set;}
    public bool IsAlive => HP > 0;   
    public Character (string name, float maxHP, float attack, float defense)
    {
        Name = name;
        MaxHP = maxHP;
        HP = MaxHP;
        Attack = attack;
        Defense = defense;
    }

    public void TakeDamage(float damage)
    {
        HP -= Math.Clamp(damage-Defense, 0, damage);
    }
    public void Heal(float amount)
    {
        HP += amount;
    }
}