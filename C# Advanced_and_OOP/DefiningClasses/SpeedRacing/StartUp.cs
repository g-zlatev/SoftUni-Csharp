using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                var model = input[0];
                var fuelAmount = double.Parse(input[1]);
                var consumption = double.Parse(input[2]);

                Car currCar = new Car(model, fuelAmount, consumption);
                carList.Add(currCar);
            }

            var input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input2[0] != "End")
            {
                string carModel = input2[1];
                var kilometers = double.Parse(input2[2]);

                Car carToDrive = carList.Where(x => x.Model == carModel).FirstOrDefault();

                carToDrive.DriveCar(carModel, kilometers);

                input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }

        }
    }
}
