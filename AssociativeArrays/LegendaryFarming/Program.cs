using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMats = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            keyMats["shards"] = 0;
            keyMats["fragments"] = 0;
            keyMats["motes"] = 0;
            string weapon = "";
            bool obtained = false;

            while (!obtained)
            {
                List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < input.Count; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (keyMats.ContainsKey(material))
                    {
                        keyMats[material] += quantity;

                        if (keyMats.Any(m => m.Value >= 250))
                        {
                            if (material == "shards")
                            {
                            weapon = "Shadowmourne";
                            }
                            else if (material == "fragments")
                            {
                                weapon = "Valanyr";
                            }
                            else if (material == "motes")
                            {
                                weapon = "Dragonwrath";
                            }
                            keyMats[material] -= 250;

                            obtained = true;
                            break;
                        }
                    }
                    else if (!junk.ContainsKey(material))
                    {
                        junk[material] = 0;
                        junk[material] = +quantity;
                    }
                }
                
            }

           
            Console.WriteLine($"{weapon} obtained!");
            keyMats = keyMats.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in keyMats)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            junk = junk.OrderBy(kvp => kvp.Key).ToDictionary(a => a.Key, b => b.Value);
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
