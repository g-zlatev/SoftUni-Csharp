﻿using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : IRepository<ICar>
    {

        private readonly IDictionary<string, ICar> carByModel;

        public CarRepository()
        {
            this.carByModel = new Dictionary<string, ICar>();
        }

        public void Add(ICar model)
        {
            if (this.carByModel.ContainsKey(model.Model))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CarExists, model));
            }

            this.carByModel.Add(model.Model, model); 
        }

        public IReadOnlyCollection<ICar> GetAll()
        {
            return this.carByModel.Values.ToList();
        }

        public ICar GetByName(string name)
        {
            ICar car = null;

            if (this.carByModel.ContainsKey(name))
            {
                car = this.carByModel[name];
            }

            return car;
        }

        public bool Remove(ICar model)
        {
            return this.carByModel.Remove(model.Model);
        }
    }
}
