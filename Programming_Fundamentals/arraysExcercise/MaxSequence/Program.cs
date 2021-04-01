using System;
using System.Linq;

namespace MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                int currentCounter = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentElement == arr[j])
                    {
                        currentCounter++;
                    }
                    else
                    {
                        break;
                    }

                }

                if (currentCounter > bestCount)
                {
                    bestCount = currentCounter;
                    bestIndex = i;
                }
            }
            string result = "";
            for (int i = 0; i < bestCount; i++)
            {
                result += arr[bestIndex] + " ";
            }
            Console.WriteLine(result);
        }
    }
}
