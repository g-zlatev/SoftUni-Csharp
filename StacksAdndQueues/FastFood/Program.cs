using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            var orderQuantity = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orderQuantity);

            Console.WriteLine(queue.Max());

            while (queue.Any() && (foodQuantity - queue.Peek()) >= 0)
            {
                foodQuantity -= queue.Dequeue();
            }
            if (queue.Any())
            {
                Console.Write($"Orders left: ");
                Console.WriteLine(String.Join(" ", queue.ToArray()));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }

        }
    }
}
