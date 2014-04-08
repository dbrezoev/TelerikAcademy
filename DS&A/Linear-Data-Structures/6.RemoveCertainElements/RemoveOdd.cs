using System;
using System.Collections.Generic;
/*Write a program that removes from given sequence all numbers that occur odd number of times. Example:
{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}
*/
namespace _6.RemoveCertainElements
{
    class RemoveOdd
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            var list = new List<int>(input);
            list.RemoveAll(x => x.OddOrEven(input) == true);
            Console.WriteLine(string.Join(", ",list));
        }
    }
}
