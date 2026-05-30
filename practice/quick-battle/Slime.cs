public class Slime : Enemy
{
    public Slime () : base ("Slime", 30, 5, 0)
    {

    }

    public override string GetUniqueTraitDescription()
    {
        return "A wobbly little creature made of living goo. It doesn't seem angry — but it will absolutely absorb your lunch.";
    }
}