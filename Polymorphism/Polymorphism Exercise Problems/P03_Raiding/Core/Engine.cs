using System;
using System.Linq;
using System.Collections.Generic;

using P03_Raiding.Models;

namespace P03_Raiding.Core
{
    public class Engine
    {
        private readonly List<BaseHero> heroes;

        public Engine()
        {
            heroes = new List<BaseHero>();
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            try
            {
                AddHero(n);

                int bossPower = int.Parse(Console.ReadLine());

                while (bossPower > 0)
                {
                    var current = this.heroes.FirstOrDefault(n => n.Name != null);

                    bossPower -= current.Power;

                    Console.WriteLine(current.CastAbility());
                    this.heroes.Remove(current);

                    if (this.heroes.Count == 0 && bossPower > 0)
                    {
                        throw new Exception("Defeat...");
                    }
                }

                if (bossPower <= 0)
                {
                    throw new Exception("Victory!");
                }
                
            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
            }
        }

        private void AddHero(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string heroClass = Console.ReadLine();

                if (heroClass == "Druid")
                {
                    Druid druid = new Druid(name, 0);
                    this.heroes.Add(druid);
                }
                else if (heroClass == "Paladin")
                {
                    Paladin paladin = new Paladin(name, 0);
                    this.heroes.Add(paladin);
                }
                else if (heroClass == "Rogue")
                {
                    Rogue rogue = new Rogue(name, 0);
                    this.heroes.Add(rogue);
                }
                else if (heroClass == "Warrior")
                {
                    Warrior warrior = new Warrior(name, 0);
                    this.heroes.Add(warrior);
                }
                else
                {
                    throw new Exception("Invalid hero!");
                }
            }
        }
    }
}
