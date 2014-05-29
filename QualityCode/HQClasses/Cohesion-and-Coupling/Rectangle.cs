namespace CohesionAndCoupling
{
    using System;

    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width must be positive number.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height must be positive number.");
                }

                this.height = value;
            }
        }

        public double CalculateDiagonal()
        {
            var diagonal = Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height));

            return diagonal;
        }
    }
}
