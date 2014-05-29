namespace Abstraction
{
    using System;

    public class Rectangle : Figure
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
                    throw new ArgumentException("Width must be positive.");
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

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        public override double CalculateArea()
        {
            double surface = this.Width * this.Height;

            return surface;
        }
    }
}
