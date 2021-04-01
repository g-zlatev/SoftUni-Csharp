using Vehicles.Contracts;

namespace Vehicles.Models
{
    public class Car : Vehicle, IVehicle
    {
        private const double defaultIncreasedConsumption = 0.9;


        public Car(double fuelQuantity, double litersPerKm) : base(fuelQuantity, litersPerKm)
        {
            
        }

        public override string Drive(double distance)
        {
            double fuelConsumed = (this.FuelConsumption + defaultIncreasedConsumption) * distance;

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
