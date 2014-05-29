namespace CohesionAndCoupling
{
    using System;

    public class Cube : Rectangle
    {
        private double depth;

        public Cube(double width, double height, double depth)
            : base(width, height)
        {
            this.Depth = depth;
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Depth must be positive number.");
                }

                this.depth = value;
            }
        }

        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;

            return volume;
        }

        public double CalculateDiagonalXYZ()
        {
            var diagonal = Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height) + (this.Depth * this.Depth));

            return diagonal;
        }

        public double CalculateDiagonalXY()
        {
            double diagonal = this.GetDistance(0, 0, this.Width, this.Height);

            return diagonal;
        }

        public double CalculateDiagonalXZ()
        {
            double distance = this.GetDistance(0, 0, this.Width, this.Depth);

            return distance;
        }

        public double CalculateDiagonalYZ()
        {
            double distance = this.GetDistance(0, 0, this.Height, this.Depth);

            return distance;
        }

        private double GetDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }
    }
}
