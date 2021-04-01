using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    public class Engine
    {

        private StationaryPhone stationaryPhone;
        private Smartphone smartphone;

        public Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartphone = new Smartphone();
        }


        public void Run()
        {
            var numberInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var urlInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var number in numberInput)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(number));
                    }
                    else if (number.Length == 10)
                    {
                        Console.WriteLine(smartphone.Call(number));
                    }
                    else
                    {
                        throw new ArgumentException("Invalid number");
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }



            }
            foreach (var url in urlInput)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(url));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }
    }

}

