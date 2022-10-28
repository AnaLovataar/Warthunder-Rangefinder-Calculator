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
                Console.WriteLine(GridOffset);

                Console.WriteLine("Enter a value for Y.");
                Double Y = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter a value for X.");
                Double X = Double.Parse(Console.ReadLine());

                Double widthHypotenuse = (Y * Y) + (X * X);
                Console.WriteLine("Hypotenuse = " + Math.Sqrt(widthHypotenuse));

                Console.WriteLine("------------------------------------------------");
            }

            while (true)
            {
                ArtyLoop();
            }
        }
    }
}