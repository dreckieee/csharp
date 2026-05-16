using System;

public class Guild
{
    private List<Member> members = new List<Member>();


    public void AddMember (Member member)
    {
        members.Add(member);
    }//end of AddMember method



    public void ListAll()
    {
        if ( members.Count == 0 ) {Console.WriteLine("\nThere are no members in the Guild Registry yet.");}
        else
        {
            Console.WriteLine("\nDisplaying members in the Guild Registry--");
            int count = 1;
            foreach (Member m in members)
            {
                Console.WriteLine($"\nMEMBER#{count}");
                Console.WriteLine($"Name: {m.Name}");
                Console.WriteLine($"Rank: {m.Rank}");
                if(m is Warrior){Console.WriteLine("Role: Warrior");}
                else if(m is Mage){Console.WriteLine("Role: Mage");}
                else if(m is Ranger){Console.WriteLine("Role: Ranger");}
                count ++;
            }
        }
    }//end of ListAll method




    public Member? FindByName (string name)
    {
        if(members.Count == 0) 
        {
            Console.WriteLine("\nThere are no members in the Guild Registry yet.");
            return null;
        }
        else
        {
            Member? found = members.Find(f => f.Name == name);
            return found;            
        }

    }//end of FindByName method



    public void ShowElites()
    {
        List<Member> elites = members.FindAll(f => f.Rank == "Elite" || f.Rank == "Archmage" || f.Rank == "Warden");
        if(elites.Count == 0) { Console.WriteLine("\nThere are no members with the highest possible rank in the Guild Registry."); }
        else
        {
            Console.WriteLine("\nDisplaying Highest Ranked Members--");
            foreach (Member m in elites)
            {
                
                Console.WriteLine($"\nName: {m.Name}");
                Console.WriteLine($"Rank: {m.Rank}");
                if(m is Warrior){Console.WriteLine("Role: Warrior");}
                else if(m is Mage){Console.WriteLine("Role: Mage");}
                else if(m is Ranger){Console.WriteLine("Role: Ranger");}
            }
        }
    }//end of ShowElites method



    public void Inspect(Member member)
    {
        if(members.Count == 0) 
        {
            Console.WriteLine("\nThere are no members in the Guild Registry yet.");
        }
        else
        {
            if ( member is Warrior w) { Console.WriteLine($"\nStrength: {w.Strength}"); }
            else if ( member is Mage m) { Console.WriteLine($"\nSpellsLearned: {m.SpellsLearned}"); }
            else if ( member is Ranger r) { Console.WriteLine($"\nKills: {r.Kills}"); }            
        }
    }//end of Inspect method


}