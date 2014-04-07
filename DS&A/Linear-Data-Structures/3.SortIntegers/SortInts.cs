using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts
 * them in an increasing order.
*/
namespace _3.SortIntegers
{
    class SortInts
    {
        static void Main(string[] args)
        {
            //SortedSet - every element will be only once in it!!!

            var list = new List<int>();
            var input = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                else
                {
                    list.Add(int.Parse(input));
                    input = Console.ReadLine();
                }
            }
            var sorted = list.OrderBy(x => x);
            var result = string.Join(", ", sorted);
            Console.WriteLine(result);
        }
    }
}
