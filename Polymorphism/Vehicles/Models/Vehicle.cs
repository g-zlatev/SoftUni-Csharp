using Vehicles.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity, double litersPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = litersPerKm;
        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; protected set; }

        public abstract string Drive(double distance);


        public void Refuel(double amount)
        {
            this.FuelQuantity += amount;
        }

    }
}
