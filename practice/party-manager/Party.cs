using System;
using System.Collections.Generic;

class Party
{//start of Class Party
    private bool IsFull()
    {
        return partyMembers.Count == 4;
    }//end of IsFull method

    private bool IsEmpty ()
    {
        return partyMembers.Count == 0;
    }//end of IsEmpty method

    public void AddHero()
    {
        if(IsFull())
        {
            Console.WriteLine($"Party if full! You cannot add more heroes.");
        }
        else
        {
            while(true)
            {
                Console.Write("\nEnter NAME of NEW Hero: ");
                string? heroName = Console.ReadLine();
                if(string.IsNullOrEmpty(heroName))
                {
                    Console.WriteLine("Invalid Name. Try again\n");
                    continue;
                }
                Hero hero1 = new Hero (heroName, 1, 100.0m, 15.0m); 
                partyMembers.Add(hero1);
                Console.WriteLine($"You have successfully added {heroName} to the party!");
                break;
            }
            
        }
    }//end of AddHero method


    public void RemoveHero()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Party is empty! You cannot remove heroes");
        }
        else
        {
            while(true)
            {
                Console.Write("\nEnter the NAME of the hero to be removed: ");
                string? heroName = Console.ReadLine();
                if(string.IsNullOrEmpty(heroName))
                {
                    Console.WriteLine("Invalid Name. Try again\n");
                    continue;
                }
                Hero? found = partyMembers.Find(heroToBeRemoved => heroToBeRemoved.Name == heroName);
                if(found == null)
                {
                    Console.WriteLine("Hero not found.");
                    break;
                }
                else
                {
                    partyMembers.Remove(found);
                    Console.WriteLine($"You have successfully removed {heroName} from the party!");
                }
                break;
            }
        }
    }//end of RemoveHero method

    public void DisplayTotalHP ()
    {
        decimal totalHP = 0.0m;
        Console.Write("\nTotal HP of Party: ");
        foreach(Hero hero in partyMembers)
        {
            totalHP += hero.Health;
        }
        Console.WriteLine(totalHP);
    }

    public void DisplayParty ()
    {
        if(IsEmpty())
        {
            Console.WriteLine("Add a hero first.");
        }
        else
        {
            Console.WriteLine("Displaying Party..\n");
            Console.WriteLine("\n============== PARTY ==============");
            int numberOfMembers = 1;
            foreach(Hero hero in partyMembers)
            {
            
                Console.WriteLine($"\nMember#{numberOfMembers}");
                hero.DisplayStats();
                numberOfMembers ++;
            }

        }
    }

    public void LevelUpHero()
    {
        while(true)
        {
            Console.Write("\nEnter the NAME of the hero to level up: ");
            string? heroName = Console.ReadLine();
            if(string.IsNullOrEmpty(heroName))
            {
                Console.WriteLine("Invalid Name. Try again\n");
                continue;
            }
            Hero? found = partyMembers.Find(heroToBeRemoved => heroToBeRemoved.Name == heroName);
            if(found == null)
            {
                Console.WriteLine("Hero not found.");
                continue;
            }
            else
            {
                found.LevelUp();
            }
            break;
        }
    }
        

    private List <Hero> partyMembers = new List <Hero>();



}//end of Class Party