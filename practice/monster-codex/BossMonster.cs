using System;

public class BossMonster : Monster
{
    public string WeaknessElement {get; private set;}
    public string Reward {get; private set;}
    public BossMonster (string name, string type, string description, string weaknessElement, string reward) : base (name,type,description)
    {
        WeaknessElement = weaknessElement;
        Reward = reward;
    }

    public override string GetEntry()
    {
        string entry = "";
        entry += "Name:".PadRight(19);
        entry += Name.ToUpper();
        entry += "\nType:".PadRight(20);
        entry += Type;
        entry += "\nDescription:".PadRight(20);
        entry += Description;
        entry += "\nWeakness Element".PadRight(20);
        entry += WeaknessElement;
        entry += "\nReward".PadRight(20);
        entry += Reward;
        return entry;
    }
}