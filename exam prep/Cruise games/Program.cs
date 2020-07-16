using System;

namespace Cruise_games
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());

            decimal sumVolleyball = 0, sumTennis = 0, sumBadminton = 0;
            int countVolleyball = 0, countTennis = 0, countBadminton = 0;
            for (int i = 0; i < gamesPlayed; i++)
            {
                string game = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());
                switch (game)
                {
                    case "volleyball":
                        countVolleyball++;
                        sumVolleyball += points * 1.07m;
                        break;

                    case "tennis":
                        countTennis++;
                        sumTennis += points * 1.05m;
                        break;

                    case "badminton":
                        countBadminton++;
                        sumBadminton += points * 1.02m;
                        break;
                }
            }
            int averageVoley = (int)(sumVolleyball / countVolleyball);
            int averageTennis = (int)(sumTennis / countTennis);
            int averageBadmin = (int)(sumBadminton / countBadminton);
            int totalPoints = (int)Math.Floor(sumBadminton + sumTennis + sumVolleyball);
            if (averageBadmin >= 75 && averageTennis >= 75 && averageVoley >= 75)
            {
                Console.WriteLine($"Congratulations, {playerName}! You won the cruise games with {totalPoints} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {playerName}, you lost. Your points are only {totalPoints}.");
            }
        }
    }
}
