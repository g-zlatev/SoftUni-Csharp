using System;
using System.Linq;
using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var truckArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Vehicle car = new Car(carArgs[1], carArgs[2]);
            Vehicle truck = new Car(truckArgs[1], truckArgs[2]);

            int num = int.Parse(Console.ReadLine());



        }
    }
}
