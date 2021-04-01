using System;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string weekDay = Console.ReadLine();
            decimal price = 0;

            switch (typeOfGroup)
            {
                case "Students": 
                    if (weekDay == "Friday")
                    {
                        price = 8.45m;
                    }
                    if (weekDay == "Saturday")
                    {
                        price = 9.80m;
                    }
                    if (weekDay == "Sunday")
                    {
                        price = 10.46m;
                    }
                    break;
                case "Business":
                    if (weekDay == "Friday")
                    {
                        price = 10.90m;
                    }
                    if (weekDay == "Saturday")
                    {
                        price = 15.60m;
                    }
                    if (weekDay == "Sunday")
                    {
                        price = 16;
                    }
                    break;
                case "Regular":
                    if (weekDay == "Friday")
                    {
                        price = 15;
                    }
                    if (weekDay == "Saturday")
                    {
                        price = 20;
                    }
                    if (weekDay == "Sunday")
                    {
                        price = 22.50m;
                    }
                    break;
            }
            decimal totalPrice = 0;
            totalPrice = numOfPeople * price;
            if (typeOfGroup == "Students" && numOfPeople >= 30)
            {
                totalPrice *= 0.85m;
            }
            if (typeOfGroup == "Business" && numOfPeople >= 100)
            {
                totalPrice = (numOfPeople - 10) * price;
            }
            if (typeOfGroup == "Regular" && numOfPeople >= 10 && numOfPeople <= 20)
            {
                totalPrice *= 0.95m;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
