namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");                
            }

            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException("Given sides cannot form a triangle.");
            }

            double p = (a + b + c) / 2;

            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Wrong number as input.");
            }            
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("No array.");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("Empty array.");
            }

            int max = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public static void PrintWithPrecision(double number, int precision)
        {
            Console.WriteLine("{0:f" + precision + "}", number);
        }

        public static void PrintAsPercent(double number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintAligned(double number, int align)
        {
            Console.WriteLine("{0," + align + "}", number);
        }

        public static bool IsLineHorizontal(double x1, double x2)
        {
            bool result;
            if (x1 == x2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public static bool IsLineVertical(double y1, double y2)
        {
            bool result;
            if (y1 == y2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
       
        public static double CalculateDistance(Point first, Point second)
        {            
            double distance = Math.Sqrt((second.X - first.X) * (second.X - first.X) + (second.Y - first.Y) * (second.Y - first.Y));

            return distance;
        }

        public static void Main()
        {            
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintWithPrecision(8.1234, 2);

            PrintAsPercent(0.43);

            PrintAligned(0.56, 10);

            var distance = CalculateDistance(new Point(2, 4), new Point(3.5, 8.9));

            Console.WriteLine(distance);

            Student pesho = new Student("pesho", "ivanov", 19);
            Student gosho = new Student("gosho", "goshov", 21);

            Console.WriteLine(pesho.IsOlderThan(gosho));            
        }
    }
}
