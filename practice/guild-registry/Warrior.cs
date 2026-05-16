    using System;

    public class Warrior : Member
    {
        public int Strength {get; set;} = 0;
        public Warrior (string name) : base (name, "Recruit") {}

        public override void Promote()
        {
            bool promoted = false;

            if (Rank == "Recruit" && Strength >= 50 ) 
            {
                Console.WriteLine("Congratulations! You are promoted to Veteran!");
                Rank = "Veteran";
                promoted = true;
            }
            if (Rank == "Veteran" && Strength >= 100 ) 
            {
                Console.WriteLine("Congratulations! You are promoted to Elite!");
                Rank = "Elite";
                promoted = true;
            }
            if (Rank == "Elite" && promoted == false)
            {
                Console.WriteLine("Your rank \"Elite\" is already the highest rank!");
            }

            else if (promoted == false){Console.WriteLine($"You are still not eligible for promotion. Strength: {Strength}");}
        }
    }