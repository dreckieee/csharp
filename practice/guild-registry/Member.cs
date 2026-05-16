using System;

public abstract class Member
{
    public string Name {get; set;}
    public string Rank {get; protected set;}
    public Member (string name, string rank)
    {
        Name = name;
        Rank = rank;
    }

    public abstract void Promote();
}