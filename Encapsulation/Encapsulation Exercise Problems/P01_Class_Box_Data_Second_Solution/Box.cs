using System;
using System.Text;

namespace P01_Class_Box_Data_Second_Solution
{
    public class Box
    {
        private const string INVALID_SIDE_EXC_MSG = "{0} cannot be zero or negative.";
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
                this.ValidateSide(value, nameof(Length));
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
                this.ValidateSide(value, nameof(Width));
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
                this.ValidateSide(value, nameof(Heigth));
                this.height = value;
            }
        }

        private void ValidateSide(double side, string paramName)
        {
            if (side <= INVALID_SIDE)
            {
                throw new ArgumentException(String.Format(INVALID_SIDE_EXC_MSG, paramName));
            }
        }

        public double SurfaceArea() => (2 * this.Length * this.Width) + (2 * this.Length * this.Heigth) + (2 * this.Width * this.Heigth);

        public double LateralSurfaceArea() => (2 * this.Length * this.Heigth) + (2 * this.Width * this.Heigth);
        
        public double Volume() => (this.Length * this.Width * this.Heigth);
        
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Surface Area - {this.SurfaceArea():F2}");
            stringBuilder.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():F2}");
            stringBuilder.AppendLine($"Volume - {this.Volume():F2}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
