using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterRaces.Repositories.Entities
{
    public class DriverRepository : IRepository<IDriver>
    {
        private readonly IDictionary<string, IDriver> driversByName;

        public DriverRepository()
        {
            this.driversByName = new Dictionary<string, IDriver>();
        }

        public void Add(IDriver model)
        {

            if (this.driversByName.ContainsKey(model.Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriversExists, model.Name));
            }

            this.driversByName.Add(model.Name, model);
        }

        public IReadOnlyCollection<IDriver> GetAll()
        {
            return this.driversByName.Values.ToList();
        }

        public IDriver GetByName(string name)
        {
            IDriver driver = null;

            if (this.driversByName.ContainsKey(name))
            {
                driver = this.driversByName[name];
            }

            return driver;
        }

        public bool Remove(IDriver model)
        {
            return this.driversByName.Remove(model.Name);
        }
    }
}
