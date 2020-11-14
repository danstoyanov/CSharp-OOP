using System;

namespace _01_Class_Box_Data
{
    public class StartUp
    {
        static void Main()
        {
            try
            {
                var lenght = double.Parse(Console.ReadLine());
                var width = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());

                var box = new Box(lenght, width, height);

                Console.WriteLine(box.SurfaceArea());
                Console.WriteLine(box.LateralSurfaceArea());
                Console.WriteLine(box.Volume());
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            // var surfArea = (2 * (lenght * width)) + (2 * (lenght * height)) + (2 * (width * height));
            // Console.WriteLine($"Surface Area: {surfArea:F2}");

            // var lateralSurfaceArea = (2 * (lenght * height)) + (2 * (width * height));
            // Console.WriteLine($"Lateral Surf Area: {lateralSurfaceArea:F2}");

            // var volume = lenght * width * height;
            // Console.WriteLine($"volume: {volume:F2}");

            /// Lateral Surface Area = 2lh + 2wh
            /// Surface Area = 2lw + 2lh + 2wh
            /// Volume = l * w * h; 
        }
    }
}
