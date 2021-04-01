using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {

        public Car()
        {
            this.TravelledDistance = 0;
        }

        public Car(string model) : this()
        {
            this.Model = model;
        }

        public Car(string model, double fuelAmount, double fuelConsumption) : this()
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
        }


        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void DriveCar(string model, double amountOfKm)
        {

            var neededFuel = amountOfKm * this.FuelConsumptionPerKilometer;

            if (FuelAmount >= neededFuel)
            {
                this.FuelAmount -= neededFuel;
                this.TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }


        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}";
        }
    }
}
