using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private readonly List<Car> data;

        private Parking()
        {
            this.data = new List<Car>();
        }

        public Parking(string type, int capacity) : this()
        {
            this.Type = type;
            this.Capacity = capacity;
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count 
        {
            get
            {
                return this.data.Count;
            }
        
        }

        public void Add(Car car)
        {
            if (this.data.Capacity + 1 <= this.Capacity)
            {
                this.data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            //Car car = this.data.FirstOrDefault(c => c.Manufacturer == manufacturer && c => c.Model == model);
            int index = this.data.FindIndex(c => c.Manufacturer == manufacturer && c => c.Model == model);

            //if (car != null)
            //{
            //    this.data.Remove(car);
            //    return true;
            //}
            if (index >= 0)
            {
                data.RemoveAt(index);
                return true;
            }
            return false;
        }

        public string GetLatestCar()
        {
            if (this.data.Any())
            {
                return this.data.OrderByDescending(c => c.Year).First();
            }

            return null;

        }

    }
}
