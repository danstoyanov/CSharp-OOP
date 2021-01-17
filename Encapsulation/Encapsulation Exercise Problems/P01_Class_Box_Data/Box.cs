using System;

namespace P01_Class_Box_Data
{
    public class Box
    {
        private const double INVALID_SIDE = 0;

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Heigth = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= INVALID_SIDE)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= INVALID_SIDE)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Heigth
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= INVALID_SIDE)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public string SurfaceArea()
        {
            double surfaceArea = (2 * (this.Length * this.Width)) + (2 * (this.Length * this.Heigth)) + (2 * (this.Width * this.Heigth));

            return $"Surface Area - {surfaceArea:F2}";
        }

        public string LateralSurfaceArea()
        {

            double lateralSurfaceArea = (2 * (this.Length * this.Heigth)) + (2 * (this.Width * this.Heigth));

            return $"Lateral Surface Area - {lateralSurfaceArea:F2}";
        }

        public string Volume()
        {
            double volume = (this.Length * this.Width * this.Heigth);

            return $"Volume - {volume:F2}";
        }
    }
}
