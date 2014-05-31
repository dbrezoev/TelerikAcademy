using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _02.Comparison
{
    public class Comparer
    {
        public const long COUNTER = 100000000;
        public static readonly Stopwatch st = new Stopwatch();
        static void Main(string[] args)
        {
            GetResult("Add integers", () =>
            {
                int result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result += i;
                }
            });

            GetResult("Add Longs", () =>
            {
                long result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result += i;
                }
            });

            GetResult("Add Doubles", () =>
            {
                double result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result += i;
                }
            });

            GetResult("Add Floats", () =>
            {
                float result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result += i;
                }
            });

            GetResult("Add Decimals", () =>
            {
                decimal result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result += i;
                }
            });

            Console.WriteLine(new string('-', Console.WindowWidth));

            GetResult("Subtract Ints", () =>
            {
                int result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result--;
                }
            });

            GetResult("Subtract Longs", () =>
            {
                long result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result--;
                }
            });

            GetResult("Subtract Doubles", () =>
            {
                double result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result--;
                }
            });

            GetResult("Subtract Floats", () =>
            {
                float result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result--;
                }
            });

            GetResult("Subtract Decimals", () =>
            {
                decimal result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result--;
                }
            });

            Console.WriteLine(new string('-', Console.WindowWidth));

            GetResult("Increment Ints", () =>
            {
                int result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result++;
                }
            });

            GetResult("Increment Longs", () =>
            {
                long result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result++;
                }
            });

            GetResult("Increment Doubles", () =>
            {
                double result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result++;
                }
            });

            GetResult("Increment Floats", () =>
            {
                float result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result++;
                }
            });

            GetResult("Increment Decimals", () =>
            {
                decimal result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result++;
                }
            });

            Console.WriteLine(new string('-', Console.WindowWidth));

            GetResult("Multiply Ints", () =>
            {
                int result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result *= 1;
                }
            });

            GetResult("Multiply Longs", () =>
            {
                long result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result *= 1;
                }
            });


            GetResult("Multiply Doubles", () =>
            {
                double result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result *= 1;
                }
            });

            GetResult("Multiply Floats", () =>
            {
                float result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result *= 1;
                }
            });

            GetResult("Multiply Decimals", () =>
            {
                decimal result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result *= 1;
                }
            });

            Console.WriteLine(new string('-', Console.WindowWidth));

            GetResult("Divide Ints", () =>
            {
                int result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result /= 1;
                }
            });

            GetResult("Multiply Longs", () =>
            {
                long result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result *= 1;
                }
            });

            GetResult("Multiply Doubles", () =>
            {
                double result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result *= 1;
                }
            });

            GetResult("Multiply Floats", () =>
            {
                float result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result *= 1;
                }
            });

            GetResult("Multiply Decimals", () =>
            {
                decimal result = 0;
                for (int i = 0; i < COUNTER; i++)
                {
                    result *= 1;
                }
            });
        }

        public static void GetResult(string title, Action action)
        {
            Console.WriteLine(title);
            st.Restart();
            action();
            st.Stop();
            Console.WriteLine(st.Elapsed);
            Console.WriteLine();
        }
    }
}
