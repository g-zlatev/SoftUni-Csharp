using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> contestants = new Dictionary<string, int>();
            foreach (var name in names)
            {
                contestants.Add(name, 0);
            }

            string input = "";

            while ((input = Console.ReadLine()) != "end of race")
            {
                string namePattern = @"([A-Z,a-z]+)";
                string distancePattern = @"([0-9])";
                string name = "";
                int distance = 0;

                MatchCollection nameLetters = Regex.Matches(input, namePattern);
                MatchCollection distanceDigits = Regex.Matches(input, distancePattern);

                foreach (Match match in nameLetters)
                {
                    name += match;
                }
                foreach (Match match in distanceDigits)
                {
                    distance += int.Parse(match.Value);
                }

                if (contestants.ContainsKey(name))
                {
                    contestants[name] += distance;
                }

            }
            contestants = contestants.OrderByDescending(x => x.Value).ToDictionary(a => a.Key, b => b.Value);
            List<string> roster = new List<string>();
            foreach (var item in contestants)
            {
                roster.Add(item.Key);
            }
            Console.WriteLine($"1st place: {roster[0]}");
            Console.WriteLine($"2nd place: {roster[1]}");
            Console.WriteLine($"3rd place: {roster[2]}");
        }
    }
}
