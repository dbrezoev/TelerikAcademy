namespace SimplifyExpression
{
    /*Refactor the following code to use proper variable naming and simplified expressions:*/
    using System;

    public class Rectangle
    {
        private double width, height;

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
                    throw new ArgumentOutOfRangeException("Width cannot be less than zero.");
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
                    throw new ArgumentOutOfRangeException("Height cannot be less than zero.");
                }

                this.height = value;
            }
        }        

        public static Rectangle Rotate(Rectangle rectangle, double angle)
        {
            var cosAngle = Math.Cos(angle);
            var sinAngle = Math.Sin(angle);

            var width = Math.Abs(cosAngle) * rectangle.width;
            var height = Math.Abs(sinAngle) * rectangle.height;

            var resultRectangle = new Rectangle(width, height);

            return resultRectangle;
        }       
    }
}
