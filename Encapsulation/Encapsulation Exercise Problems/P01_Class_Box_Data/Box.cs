using System;

namespace _01_Class_Box_Data
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public string SurfaceArea()
        {
            var currResult = (2 * (length * width)) + (2 * (length * height)) + (2 * (width * height));
            return $"Surface Area - {currResult:F2}";
        }

        public string LateralSurfaceArea()
        {
            var currResult = (2 * (length * height)) + (2 * (width * height));
            return $"Lateral Surface Area - {currResult:F2}";
        }

        public string Volume()
        {
            var currResult = (length * width * height);
            return $"Volume - {currResult:F2}";
        }
    }
}
