    using System;

    public class Mage : Member
    {
        public int SpellsLearned {get; set;} = 0;
        public Mage (string name) : base (name, "Apprentice") {}

        public override void Promote()
        {
            bool promoted = false;

            if (Rank == "Apprentice" && SpellsLearned >= 10 ) 
            {
                Console.WriteLine("Congratulations! You are promoted to Adept!");
                Rank = "Adept";
                promoted = true;
            }
            if (Rank == "Adept" && SpellsLearned >= 25 ) 
            {
                Console.WriteLine("Congratulations! You are promoted to Archmage!");
                Rank = "Archmage";
                promoted = true;
            }
            if (Rank == "Archmage" && promoted == false)
            {
                Console.WriteLine("Your rank \"Archmage\" is already the highest rank!");
            }

            else if (promoted == false){Console.WriteLine($"You are still not eligible for promotion. Spells Learned: {SpellsLearned}");}
        }
    }