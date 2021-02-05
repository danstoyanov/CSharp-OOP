using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main()
        {
            var rectangle = new Rectangle(3, 4);
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.CalculateArea());

            var circle = new Circle(3);
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());

            Console.WriteLine(rectangle.Draw());
            Console.WriteLine(circle.Draw());
        }
    }
}
  