using System;
using System.Collections.Generic;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mats = new Dictionary<string, int>();

            //string input = "";
            //int counter = 0;
            //string currMat = "";

            //while ((input = Console.ReadLine()) != "stop")
            //{
            //    if (counter % 2 == 0)
            //    {
            //        currMat = input;
            //        if (!mats.ContainsKey(currMat))
            //        {
            //            mats[currMat] = 0;
            //        }

            //    }
            //    else
            //    {
            //        int currValue = int.Parse(input);
            //        mats[currMat] += currValue;

            //    }
            //    counter++;
            //}
            string product = "";
            while ((product = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!mats.ContainsKey(product))
                {
                    mats[product] = 0;
                }

                mats[product] += quantity;
            }


            foreach (var item in mats)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
