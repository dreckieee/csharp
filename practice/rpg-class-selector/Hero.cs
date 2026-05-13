using System;


public abstract class Hero
{
    public string Name {get; set;}
    public int Level {get; set;}

    public Hero (string name, int level)
    {
        Name = name;
        Level = level; 
    }

    public abstract void GetStats();

}