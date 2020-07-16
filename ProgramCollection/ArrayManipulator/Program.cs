using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] action = Console.ReadLine().Split().ToArray();
            string oddEven = "";
            int index = 0;

            string command = action[0]; ;

            while (command != "end")
            {
                if (command == "exchange")
                {
                    index = int.Parse(action[1]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        Exchange(numbers, index);
                    }

                }
                else if (command == "max")
                {
                    oddEven = action[1].ToString();
                    if (oddEven == "odd")
                    {
                        MaxOdd(index, numbers);
                    }
                    else if (oddEven == "even")
                    {
                        MaxEven(index, numbers);
                    }
                }
                else if (command == "min")
                {
                    oddEven = action[1].ToString();
                    if (oddEven == "odd")
                    {
                        MinOdd(index, numbers);
                    }
                    else if (oddEven == "even")
                    {
                        MinEven(index, numbers);
                    }
                }
                else if (command == "first")
                {
                    index = int.Parse(action[1]);
                    oddEven = action[2].ToString();
                    if (oddEven == "odd")
                    {
                        FirstCountOdd(numbers, index);
                    }
                    else if (oddEven == "even")
                    {
                        FirstCountEven(numbers, index);
                    }
                }
                else if (command == "last")
                {
                    index = int.Parse(action[1]);
                    oddEven = action[2].ToString();
                    if (oddEven == "odd")
                    {
                        LastCountOdd(numbers, index);
                    }
                    else if (oddEven == "even")
                    {
                        LastCountEven(numbers, index);
                    }
                }

                action = Console.ReadLine().Split().ToArray();
                command = action[0];
            }

            Console.WriteLine($"[{String.Join(", ", numbers)}]");
        }
        static List<int> Exchange(List<int> numbers, int index)
        {

            List<int> firstPart = numbers.Take(index + 1).ToList();
            List<int> secondPart = numbers.Skip(index + 1).ToList();

            secondPart.AddRange(firstPart);
            numbers.Clear();
            numbers.AddRange(secondPart);

            return numbers;


        }
        static void MaxEven(int index, List<int> numbers)
        {
            int maxNumber = int.MinValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] >= maxNumber)
                {
                    maxNumber = numbers[i];
                    index = i;
                }
            }
            if (maxNumber == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void MaxOdd(int index, List<int> numbers)
        {
            int maxNumber = int.MinValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0 && numbers[i] >= maxNumber)
                {
                    maxNumber = numbers[i];
                    index = i;
                }
            }
            if (maxNumber == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void MinEven(int index, List<int> numbers)
        {
            int minNumber = int.MaxValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] <= minNumber)
                {
                    minNumber = numbers[i];
                    index = i;
                }
            }
            if (minNumber == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void MinOdd(int index, List<int> numbers)
        {
            int minNumber = int.MaxValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0 && numbers[i] <= minNumber)
                {
                    minNumber = numbers[i];
                    index = i;
                }
            }
            if (minNumber == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void FirstCountOdd(List<int> numbers, int index)
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    odds.Add(numbers[i]);
                }
            }
            if (numbers.Count < index)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            if (odds.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{String.Join(", ", odds.Take(index))}]");
            }

        }
        static void FirstCountEven(List<int> numbers, int index)
        {
            List<int> evens = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
            }
            if (numbers.Count < index)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            else if (evens.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{String.Join(", ", evens.Take(index))}]");
            }


        }
        static void LastCountOdd(List<int> numbers, int index)
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    odds.Add(numbers[i]);
                }
            }

            if (numbers.Count < index)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            else if (odds.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{String.Join(", ", odds.Skip(odds.Count - index))}]");
            }
        }
        static void LastCountEven(List<int> numbers, int index)
        {
            List<int> evens = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
            }

            if (numbers.Count < index)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            else if (evens.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{String.Join(", ", evens.Skip(evens.Count - index))}]");
            }
        }
    }
}