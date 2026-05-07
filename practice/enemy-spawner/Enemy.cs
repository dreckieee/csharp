using System;


class Enemy
{
    public string Name {get; set;}
    public string Type {get; set;}
    public decimal HP {get; set;}


    public Enemy ( string name, string type, decimal hp )
    {
        Name = name;
        Type = type;
        HP = hp;
    }

    public void TakeDamage (decimal damage)
    {
        HP -= damage;
    }
}//end of Enemy class
