public class Potion : Item
{
    public float HealAmount {get; set;}
   
    public Potion (string name, int quantity, float healAmount) : base (name, quantity)
    {
        HealAmount = healAmount;
    }
}