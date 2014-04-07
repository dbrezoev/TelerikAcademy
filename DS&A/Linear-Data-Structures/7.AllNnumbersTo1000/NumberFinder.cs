using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that finds in given array of integers (all belonging to the range [0..1000])
 * how many times each of them occurs.
Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
2  2 times
3  4 times
4  3 times

 */
namespace _7.AllNnumbersTo1000
{
    class NumberFinder
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {-3, 3, 4, 4, 2, 3, 3, 4, 3, 2,6789 };
            var list = new List<int>(arr);
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                int currentNumber = list[i];
                if (currentNumber<0 || currentNumber>1000)
                {
                    continue;
                }
                int value;
                if (!dictionary.TryGetValue(currentNumber, out value))
                {
                    dictionary.Add(currentNumber, 1);
                }
                else
                {
                    dictionary[currentNumber]++;
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(string.Format("{0} --> {1} times",item.Key,item.Value));
            }
        }
    }
}
