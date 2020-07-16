using System;

namespace PB_exam_01._12._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintBuckets = int.Parse(Console.ReadLine());
            int wallpaperRolls = int.Parse(Console.ReadLine());
            double glovesPrice = double.Parse(Console.ReadLine());
            double brushPrice = double.Parse(Console.ReadLine());

            double gloves = Math.Ceiling(wallpaperRolls * 0.35);
            double brushes = Math.Floor(paintBuckets * 0.48);

            double totalGlovePrice = gloves * glovesPrice;
            double totalBrushPrice = brushes * brushPrice;

            double totalPrice = paintBuckets * 21.50 + wallpaperRolls * 5.20 + totalBrushPrice + totalGlovePrice;
            Console.WriteLine($"This delivery will cost {totalPrice/15:f2} lv.");
        }
    }
}
