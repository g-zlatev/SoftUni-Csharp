using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = input[0];

                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);

                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);

                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);

                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Engine engine = CreateEngine(engineSpeed, enginePower);
                Cargo cargo = CreateCargo(cargoWeight, cargoType);

                List<Tire> tires = new List<Tire>();
                tires.Add(CreateTire(tire1Pressure, tire1Age));
                tires.Add(CreateTire(tire2Pressure, tire2Age));
                tires.Add(CreateTire(tire3Pressure, tire3Age));
                tires.Add(CreateTire(tire4Pressure, tire4Age));


                Car car1 = new Car(model, engine, cargo, tires);

                //Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);

                cars.Add(car1);
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "fragile":

                    List<Car> fragileCars = cars.Where(x => x.Cargo.Type == "fragile").Where(x => x.Tires.Any(x=> x.Pressure < 1)).ToList();

                    Console.WriteLine(String.Join(Environment.NewLine, fragileCars).TrimEnd());

                    break;

                case "flamable":
                    List<Car> flamableCars = cars.Where(x => x.Cargo.Type == "flamable").Where(x => x.Engine.Power > 250).ToList();

                    Console.WriteLine(String.Join(Environment.NewLine, flamableCars).TrimEnd());

                    break;
            }

        }

        static Engine CreateEngine(int speed, int power)
        {
            return new Engine(speed, power);

        }

        static Cargo CreateCargo(int weight, string type)
        {
            return new Cargo(weight, type);
        }

        static Tire CreateTire(double pressure, int age)
        {
            return new Tire(age, pressure);
        }
    }
}
