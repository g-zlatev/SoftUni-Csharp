using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private readonly List<IComponent> components;
        private readonly List<IPeripheral> peripherals;

        private decimal totalPrice;
        private decimal totalComponentPrice;
        private decimal totalPeriferalPrice;
        private double componentsPerf;
        private double totalComponentPerform;
        private double averageOverallPerfPeripherals;

        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance) : base(id, manufacturer, model, price, overallPerformance)
        {
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }


        public IReadOnlyCollection<IComponent> Components => components;

        public IReadOnlyCollection<IPeripheral> Peripherals => peripherals;

        //TODO: check overall performance in comp
        public override double OverallPerformance
        {
            get
            {
                if (this.components.Count <= 0)
                {
                    return base.OverallPerformance;
                }

                foreach (var component in this.components)
                {
                    this.componentsPerf += component.OverallPerformance;
                }

                this.totalComponentPerform = componentsPerf / components.Count;

                var overallPerf = base.OverallPerformance + this.totalComponentPerform;
                return overallPerf;
            }
        }

        //TODO: check price logic
        public override decimal Price
        {
            get
            {
                if (this.components.Count > 0)
                {
                    foreach (var component in this.components)
                    {
                        this.totalComponentPrice += component.Price;
                    }
                }

                if (this.peripherals.Count > 0)
                {
                    foreach (var peripheral in this.peripherals)
                    {
                        this.totalPeriferalPrice += peripheral.Price;
                    }
                }

                this.totalPrice = base.Price + this.totalComponentPrice + this.totalPeriferalPrice;

                return this.totalPrice;
            }
        }

        //TODO: average overall perif performance
        private double PeripheralPerformance
        {
            get
            {
                double totalPerifPerf = 0;
                if (this.peripherals.Count > 0)
                {
                    foreach (var peripheral in peripherals)
                    {
                        totalPerifPerf += peripheral.OverallPerformance;
                    }

                    this.averageOverallPerfPeripherals = totalPerifPerf / this.peripherals.Count;
                }

                return this.averageOverallPerfPeripherals;
            }
        }

        public void AddComponent(IComponent component)
        {
            if (this.components.Any(c => c.GetType().Name == component.GetType().Name))
            {
                //var existingComponent = this.components.FirstOrDefault(c => c.GetType().Name == component.GetType().Name);
                throw new ArgumentException(
                    string.Format(ExceptionMessages.ExistingComponent,
                        component.GetType().Name, this.GetType().Name, this.Id));
                //throw new ArgumentException($"Component {component.GetType().Name} already exists in {this.GetType().Name} with Id {this.Id}.");
            }

            this.components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (this.peripherals.Any(c => c.GetType().Name == peripheral.GetType().Name))
            {
                //var existingPeriferal = this.peripherals.FirstOrDefault(c => c.GetType().Name == peripheral.GetType().Name);
                throw new ArgumentException(
                    string.Format(ExceptionMessages.ExistingPeripheral,
                        peripheral.GetType().Name, this.GetType().Name, this.Id));
            }

            this.peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (this.components.Count <= 0 || !(this.components.Any(c => c.GetType().Name == componentType)))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingComponent, componentType, this.GetType().Name, this.Id));
            }

            var compToRemove = this.components.FirstOrDefault(c => c.GetType().Name == componentType);
            this.components.RemoveAll(c => c.GetType().Name == componentType);

            return compToRemove;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (this.peripherals.Count <= 0 || !(this.peripherals.Any(c => c.GetType().Name == peripheralType)))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingPeripheral, peripheralType, this.GetType().Name, this.Id));
            }

            var perifToRemove = this.peripherals.FirstOrDefault(c => c.GetType().Name == peripheralType);
            this.components.RemoveAll(c => c.GetType().Name == peripheralType);

            return perifToRemove;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Overall Performance: {this.OverallPerformance}. Price: {this.Price} - {this.GetType().Name}: {this.Manufacturer} {this.Model} (Id: {this.Id})");
            sb.AppendLine($" Components ({this.components.Count}):");

            //TODO: possible null ref ex foreach components sb

            foreach (var component in components)
            {
                sb.AppendLine("  " + component.ToString());
            }

            sb.AppendLine($" Peripherals ({this.peripherals.Count}); Average Overall Performance ({this.PeripheralPerformance}):");

            foreach (var peripheral in peripherals)
            {
                sb.AppendLine("  " + peripheral.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
