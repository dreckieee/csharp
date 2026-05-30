public class Goblin : Enemy
{
    public Goblin () : base ("Goblin", 50, 10, 3)
    {

    }

    public override string GetUniqueTraitDescription()
    {
        return "Small, scrappy, and absolutely convinced they are the smartest creature in the room. They are not. But you should still watch your pockets.";
    }
}