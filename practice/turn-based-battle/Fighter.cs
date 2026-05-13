using System;

public abstract class Fighter
{
    public string Name {get; set;}
    public decimal HP {get; set;}
    public Fighter (string name, decimal hp)
    {
        Name = name;
        HP = hp;
    }

    public abstract void Attack (Fighter target);



}