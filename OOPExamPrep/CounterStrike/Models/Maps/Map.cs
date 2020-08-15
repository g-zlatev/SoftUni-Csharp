using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        public string Start(ICollection<IPlayer> players)
        {
            var terrorists = players.Where(t => t.GetType() == typeof(Terrorist)).ToList();
            var counterTerrorists = players.Where(ct => ct.GetType() == typeof(CounterTerrorist)).ToList();


            while (terrorists.Any(x => x.IsAlive) && counterTerrorists.Any(y => y.IsAlive))
            {
                foreach (var terrorist in terrorists)
                {
                    if (!terrorist.IsAlive)
                    {
                        continue;
                    }
                    foreach (var counterTerr in counterTerrorists)
                    {
                        if (!counterTerr.IsAlive)
                        {
                            continue;
                        }
                        counterTerr.TakeDamage(terrorist.Gun.Fire());
                    }
                }

                foreach (var counterTerrorist in counterTerrorists)
                {
                    if (!counterTerrorist.IsAlive)
                    {
                        continue;
                    }
                    foreach (var terr in terrorists)
                    {
                        if (!terr.IsAlive)
                        {
                            continue;
                        }
                        terr.TakeDamage(counterTerrorist.Gun.Fire());
                    }
                }

            }

            var winningTeam = "";

            if (terrorists.Any(t => t.IsAlive))
            {
                winningTeam = "Terrorist";
            }
            else if (counterTerrorists.Any(ct => ct.IsAlive))
            {
                winningTeam = "Counter Terrorist";
            }

            return $"{winningTeam} wins!";
        }
    }
}
