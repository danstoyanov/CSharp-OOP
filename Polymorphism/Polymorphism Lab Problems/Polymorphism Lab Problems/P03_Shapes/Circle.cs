using System;

namespace Shapes
{
    public class Circle : Shape, IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            private set
            {
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
