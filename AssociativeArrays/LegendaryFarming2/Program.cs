using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> keyMats = new Dictionary<string, int>();
            keyMats["shards"] = 0;
            keyMats["fragments"] = 0;
            keyMats["motes"] = 0;

            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool notDone = true;
            string weapon = "";

            while (notDone)
            {
                for (int i = 0; i < input.Length - 1; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {

                        keyMats[material] += quantity;
                        if (keyMats[material] >= 250)
                        {
                            switch (material)
                            {
                                case "shards":
                                    weapon = "Shadowmourne";
                                    break;
                                case "fragments":
                                    weapon = "Valanyr";
                                    break;
                                case "motes":
                                    weapon = "Dragonwrath";
                                    break;
                            }
                            keyMats[material] -= 250;
                            notDone = false;
                            break;
                        }

                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, quantity);
                        }
                        else
                        {
                            junk[material] += quantity;
                        }
                    }
                }
                if (notDone == false)
                {
                    break;
                }
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"{weapon} obtained!");
            keyMats = keyMats.OrderByDescending(x => x.Value).ThenBy(y => y.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var kvp in keyMats)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            junk = junk.OrderBy(x => x.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}

