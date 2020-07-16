using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double inputMoney = 0;
            double inputTotalSum = 0;

            while (command != "Start")
            {
                inputMoney = double.Parse(command);
                if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney == 0.5 || inputMoney == 1 || inputMoney == 2)
                {
                    inputTotalSum += inputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputMoney}");
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();

            {
                while (command != "End")
                {
                    string product = command;
                    double productPrice = 0;
                    switch (product)
                    {
                        case "Nuts":
                            productPrice = 2.0;
                            if (inputTotalSum >= productPrice)
                            {
                                Console.WriteLine("Purchased nuts");
                                inputTotalSum -= productPrice;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                                break;
                            }
                            break;
                        case "Water":
                            productPrice = 0.7;
                            if (inputTotalSum >= productPrice)
                            {
                                Console.WriteLine("Purchased water");
                                inputTotalSum -= productPrice;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                                break;
                            }
                            break;
                        case "Crisps":
                            productPrice = 1.5;
                            if (inputTotalSum >= productPrice)
                            {
                                Console.WriteLine("Purchased crisps");
                                inputTotalSum -= productPrice;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                                break;
                            }
                            break;
                        case "Soda":
                            productPrice = 0.8;
                            if (inputTotalSum >= productPrice)
                            {
                                Console.WriteLine("Purchased soda");
                                inputTotalSum -= productPrice;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                                break;
                            }
                            break;
                        case "Coke":
                            productPrice = 1.0;
                            if (inputTotalSum >= productPrice)
                            {
                                Console.WriteLine("Purchased coke");
                                inputTotalSum -= productPrice;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                                break;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid product");
                            inputTotalSum -= productPrice;
                            break;
                    }

                    command = Console.ReadLine();

                    if (command == "End")
                    {
                        Console.WriteLine($"Change: {inputTotalSum:f2}");
                    }
                }

            }

        }
    }
}
