public class Troll : Enemy
{
    public Troll () : base ("Troll", 80, 15, 6)
    {

    }

    public override string GetUniqueTraitDescription()
    {
        return "Big, grumpy, and surprisingly sensitive about its hair. Hits hard. Thinks slow. Still enough to ruin your whole afternoon.";
    }
}