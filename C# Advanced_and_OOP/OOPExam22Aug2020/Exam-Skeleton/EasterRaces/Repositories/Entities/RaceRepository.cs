using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository : IRepository<IRace>
    {

        private readonly IDictionary<string, IRace> racesByName;

        public RaceRepository()
        {
            this.racesByName = new Dictionary<string, IRace>();
        }

        public void Add(IRace model)
        {
            if (this.racesByName.ContainsKey(model.Name))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExists, model.Name));
            }

            this.racesByName.Add(model.Name, model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return this.racesByName.Values.ToList();
        }

        public IRace GetByName(string name)
        {
            IRace race = null;

            if (this.racesByName.ContainsKey(name))
            {
                race = this.racesByName[name];
            }

            return race;
        }

        public bool Remove(IRace model)
        {
            return this.racesByName.Remove(model.Name);
        }
    }
}
