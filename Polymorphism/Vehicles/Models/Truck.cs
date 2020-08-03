using Vehicles.Contracts;

namespace Vehicles.Models
{
    public class Truck : Vehicle, IVehicle
    {
        private const double defaultIncreasedConsumption = 1.6;
        private const double defaultLostFuel = 0.95;

        public Truck(double fuelQuantity, double litersPerKm) : base(fuelQuantity, litersPerKm)
        {

        }

        public override string Drive(double distance)
        {
            double fuelConsumed = ((this.FuelConsumption + defaultIncreasedConsumption) * distance) * defaultLostFuel;

            if (this.FuelQuantity > fuelConsumed)
            {
                return $"{this.GetType().ToString()} travelled {distance} km";
                this.FuelQuantity -= fuelConsumed;
            }
            else
            {
                return $"{this.GetType().ToString()} needs refueling";
            }
        }

        //public void Refuel(double amount)
        //{
        //    this.FuelQuantity += amount;
        //}
    }
}
