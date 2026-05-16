    using System;

    public class Ranger : Member
    {
        public int Kills {get; set;} = 0;
        public Ranger (string name) : base (name, "Scout") {}

        public override void Promote()
        {
            bool promoted = false;

            if (Rank == "Scout" && Kills >= 30 ) 
            {
                Console.WriteLine("Congratulations! You are promoted to Hunter!");
                Rank = "Hunter";
                promoted = true;
            }
            if (Rank == "Hunter" && Kills >= 75 ) 
            {
                Console.WriteLine("Congratulations! You are promoted to Warden!");
                Rank = "Warden";
                promoted = true;
            }
            if (Rank == "Warden" && promoted == false)
            {
                Console.WriteLine("Your rank \"Warden\" is already the highest rank!");
            }

            else if (promoted == false){Console.WriteLine($"You are still not eligible for promotion. Kills: {Kills}");}
        }
    }