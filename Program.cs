using System;

namespace APCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Double GridOffset;

            Console.WriteLine("Enter the Grid Offset AKA Meters in the bottom right corner of the tactical map.");
            GridOffset = Double.Parse(Console.ReadLine());

            void ArtyLoop()
            {

                Console.WriteLine("Enter your current Y position.");
                Double Y1 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your current X position.");
                Double X1 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your target's current Y position.");
                Double Y2 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your target's current X position.");
                Double X2 = Double.Parse(Console.ReadLine());

                Double Distance = Math.Sqrt(((Y2 - Y1) * (Y2 - Y1)) + ((X2 - X1) * (X2 - X1)));

                Double DistanceMeters = (Distance) * (GridOffset);

                Console.WriteLine(DistanceMeters);

                Console.WriteLine("------------------------------------------------");
            }

            while (true)
            {
                ArtyLoop();
            }
        }
    }
}