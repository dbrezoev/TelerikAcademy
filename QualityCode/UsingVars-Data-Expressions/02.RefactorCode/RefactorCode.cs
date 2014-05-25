namespace _02.RefactorCode
{
    using System;

    public class RefactorCode
    {
        public static void PrintStatistics(double[] numbers)
        {
            Console.WriteLine(CalculateMax(numbers));
            Console.WriteLine(CalculateMin(numbers));
            Console.WriteLine(CalculateAverage(numbers));
        }

        public static void Main()
        {
            double[] inputNumbers = new double[] { 5, 6, 9.3, 0.1, 10.9 };
            PrintStatistics(inputNumbers);
        }

        private static double CalculateMax(double[] numbers)
        {
            double max = double.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        private static double CalculateMin(double[] numbers)
        {
            double min = double.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        private static double CalculateAverage(double[] numbers)
        {
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = sum / numbers.Length;
            return average;
        }        
    }
}
