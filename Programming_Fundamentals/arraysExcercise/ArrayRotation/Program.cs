using System;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());
            // rotations = rotations % arr.Length; - optimization if we have a hella lot of rotations

            for (int i = 0; i < rotations; i++)
            {
                string temp = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length-1] = temp;
            }
            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
