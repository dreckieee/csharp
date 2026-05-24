using System;

public class CommonMonster : Monster
{
    public string SpawnLocation {get; private set;}
    public CommonMonster (string name, string type, string description, string spawnLocation) : base (name,type,description)
    {
        SpawnLocation = spawnLocation;
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
        entry += "\nSpawn Location".PadRight(20);
        entry += SpawnLocation;
        return entry;
    }
}