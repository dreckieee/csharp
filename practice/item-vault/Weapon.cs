public class Weapon
{
    public string Name {get; set;}
    public WeaponType Type {get; set;}

    public Weapon (string name, WeaponType type)
    {
        Name = name;
        Type = type;
    }

    public override string ToString()
    {
        string result = $"\nName: {Name}\nWeapon Type: {Type}\n";
        return result;
    }
}