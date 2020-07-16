using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroNumber = int.Parse(Console.ReadLine());
            SortedDictionary<string, int> heroHP = new SortedDictionary<string, int>();
            SortedDictionary<string, int> heroMP = new SortedDictionary<string, int>();

            for (int i = 0; i < heroNumber; i++)
            {
                string[] heroStats = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = heroStats[0];
                int healthPoints = int.Parse(heroStats[1]);
                int manaPoints = int.Parse(heroStats[2]);
                heroHP[heroName] = healthPoints;
                heroMP[heroName] = manaPoints;
            }

            string[] commandInput = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string command = commandInput[0];
            string heroName1 = "";

            while ((commandInput[0]) != "End")
            {
                command = commandInput[0];
                heroName1 = commandInput[1];

                if (command == "CastSpell")
                {
                    int mpNeeded = int.Parse(commandInput[2]);
                    string spellName = commandInput[3];
                    if (heroMP[heroName1] >= mpNeeded)
                    {
                        heroMP[heroName1] -= mpNeeded;
                        Console.WriteLine($"{heroName1} has successfully cast {spellName} and now has {heroMP[heroName1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName1} does not have enough MP to cast {spellName}!");
                    }
                }

                if (command == "TakeDamage")
                {
                    if (heroHP.ContainsKey(heroName1))
                    {
                        int damage = int.Parse(commandInput[2]);
                        string attacker = commandInput[3];

                        if (heroHP[heroName1] > 0)
                        {
                            heroHP[heroName1] -= damage;
                            if (heroHP[heroName1] <= 0)
                            {
                                Console.WriteLine($"{heroName1} has been killed by {attacker}!");
                                heroHP.Remove(heroName1);
                                heroMP.Remove(heroName1);
                                continue;
                            }
                            Console.WriteLine($"{heroName1} was hit for {damage} HP by {attacker} and now has {heroHP[heroName1]} HP left!");
                        }
                    }
                }

                if (command == "Recharge")
                {
                    int mpAmount = int.Parse(commandInput[2]);
                    int tempMP = heroMP[heroName1];
                    heroMP[heroName1] += mpAmount;
                    if (heroMP[heroName1] > 200)
                    {
                        heroMP[heroName1] = 200;
                        mpAmount = 200 - tempMP;
                    }
                    Console.WriteLine($"{heroName1} recharged for {mpAmount} MP!");
                }

                if (command == "Heal")
                {
                    int hpAmount = int.Parse(commandInput[2]);
                    int tempHP = heroHP[heroName1];
                    heroHP[heroName1] += hpAmount;
                    if (heroHP[heroName1] > 100)
                    {
                        heroHP[heroName1] = 100;
                        hpAmount = 100 - tempHP;
                    }
                    Console.WriteLine($"{heroName1} healed for {hpAmount} HP!");
                }

                commandInput = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var hero in heroHP.OrderByDescending(x => x.Value))
            {
                Console.WriteLine(hero.Key);

                Console.WriteLine($"HP:  {hero.Value}");
                Console.WriteLine($"MP:  {heroMP[hero.Key]}");
            }
        }
     

    }
}
