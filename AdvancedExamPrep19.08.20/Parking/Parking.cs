using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private readonly ICollection<Car> data;

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;

            this.data = new List<Car>();
        }

        public string Type { get; private set; }

        public int Capacity { get; private set; }

        public int Count => this.data.Count;


        public void Add(Car car)
        {
            if (this.data.Count >= this.Capacity)
            {
                throw new ArgumentException("Parking capacity is full!");
            }
            this.data.Add(car);
        }

        public bool Remove(string manufacturer, string model)
        {
           var carToRemove = this.data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);

           return this.data.Remove(carToRemove);
        }

        public Car GetLatestCar()
        {
            if (this.data.Count == 0)
            {
                return null;
            }

            var latestCar = this.data.OrderByDescending(y => y.Year).FirstOrDefault();
            return latestCar;

        }

        //TODO: add if/else if necessary
        public Car GetCar(string manufacturer, string model)
        {
            var car = this.data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);

            return car;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {this.Type}:");

            foreach (var car in data)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
