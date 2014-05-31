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
        public const long COUNTER = 100000;
        public static readonly Stopwatch st = new Stopwatch();
        static void Main(string[] args)
        {
            GetResult("Square root float", () =>
            {
                for (float i = 0; i < COUNTER; i++)
                {
                    Math.Sqrt(i);
                }
            });

            GetResult("Square root double", () =>
            {
                for (double i = 0; i < COUNTER; i++)
                {
                    Math.Sqrt(i);
                }
            });

            GetResult("Square root int", () =>
            {
                for (int i = 0; i < COUNTER; i++)
                {
                    Math.Sqrt(i);
                }
            });

            Console.WriteLine(new string('-', Console.WindowWidth));

            GetResult("Log double", () =>
            {
                for (double i = 0; i < COUNTER; i++)
                {
                    Math.Log(i);
                }
            });

            GetResult("Log float", () =>
            {
                for (float i = 0; i < COUNTER; i++)
                {
                    Math.Log(i);
                }
            });

            GetResult("Log int", () =>
            {
                for (int i = 0; i < COUNTER; i++)
                {
                    Math.Log(i);
                }
            });

            Console.WriteLine(new string('-', Console.WindowWidth));

            GetResult("Sin int", () =>
            {
                for (int i = 0; i < COUNTER; i++)
                {
                    Math.Sin(i);
                }
            });

            GetResult("Sin float", () =>
            {
                for (int i = 0; i < COUNTER; i++)
                {
                    Math.Sin(i);
                }
            });

            GetResult("Sin double", () =>
            {
                for (double i = 0; i < COUNTER; i++)
                {
                    Math.Sin(i);
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
