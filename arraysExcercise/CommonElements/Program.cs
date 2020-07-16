using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] Arr1 = Console.ReadLine().Split();
            string[] Arr2 = Console.ReadLine().Split();
            string result = string.Empty;

            //for (int i = 0; i < Arr2.Length; i++)
            //{
            //    for (int j = 0; j < Arr1.Length; j++)
            //    {
            //        if (Arr1[j] == Arr2[i])
            //        {
            //            result += Arr2[i] + " ";
            //        }

            //    }

            //}

            foreach (var item1 in Arr2)
            {
                foreach (var item2 in Arr1)
                {
                    if (item1 == item2)
                    {
                        result += item1 + " ";
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
