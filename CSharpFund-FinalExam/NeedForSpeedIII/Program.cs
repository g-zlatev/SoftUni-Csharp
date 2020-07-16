using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();

            for (int i = 0; i < numOfCars; i++)
            {
                string[] inputCars = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string carName = inputCars[0];
                int mileage = int.Parse(inputCars[1]);
                int fuel = int.Parse(inputCars[2]);
                cars.Add(carName, new List<int> { mileage, fuel });
            }

            string[] command = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "Stop")
            {
                if (command[0] == "Drive")
                {
                    string currentCar = command[1];
                    int distance = int.Parse(command[2]);
                    int fuelNeeded = int.Parse(command[3]);

                    if (cars[currentCar][1] >= fuelNeeded)
                    {
                        cars[currentCar][0] += distance;
                        cars[currentCar][1] -= fuelNeeded;
                        Console.WriteLine($"{currentCar} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
                        if (cars[currentCar][0] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {currentCar}!");
                            cars.Remove(currentCar);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }

                }
                if (command[0] == "Refuel")
                {
                    string currentCar = command[1];
                    int fuelRefilled = int.Parse(command[2]);
                    int currentFuel = cars[currentCar][1];
                    cars[currentCar][1] += fuelRefilled;
                    if (cars[currentCar][1] > 75)
                    {
                        int actuallyRefilled = 75 - currentFuel;
                        Console.WriteLine($"{currentCar} refueled with {actuallyRefilled} liters");
                        cars[currentCar][1] = 75;
                    }
                    else
                    {
                        Console.WriteLine($"{currentCar} refueled with {fuelRefilled} liters");
                    }
                }
                if (command[0] == "Revert")
                {
                    string currentCar = command[1];
                    int kilometers = int.Parse(command[2]);

                    cars[currentCar][0] -= kilometers;
                    if (cars[currentCar][0] < 10000)
                    {
                        cars[currentCar][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{currentCar} mileage decreased by {kilometers} kilometers");
                    }
                }

                command = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }

            cars = cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            foreach (var item in cars)
            {
            Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }
            
        }
    }
}
