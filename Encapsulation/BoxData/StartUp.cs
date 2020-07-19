using System;

namespace BoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, heigth);

                double boxSurfaceArea = box.CalculateSurfaceArea();
                double boxLateralSurfaceArea = box.CalculateLateralSurfaceArea();
                double boxVolume = box.CalculateVolume();

                Console.WriteLine($"Surface Area - {boxSurfaceArea:f2}");
                Console.WriteLine($"Lateral Surface Area - {boxLateralSurfaceArea:f2}");
                Console.WriteLine($"Volume - {boxVolume:f2}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
