using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that removes from given sequence all numbers that occur odd number of times. Example:
{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}
*/
namespace _6.RemoveCertainElements
{
    class RemoveOdd
    {
        //static int[] Remove(int[] arr)
        //{
        //    var list = new List<int>(arr);
        //    var dict = new Dictionary<int, int>();
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        int currentNumber=arr[i];
        //        int value;
        //        if (!dict.TryGetValue(currentNumber, out value))
        //        {
        //            dict.Add(currentNumber, 1);
        //        }
        //        else
        //        {
        //            dict[currentNumber]++;
        //        }
        //        list.RemoveAll(x => x.OddOrEven(arr) == true);
                
        //    }
        //    return list.ToArray();
        //}
        static void Main(string[] args)
        {
            int[] input = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            var list = new List<int>(input);
            list.RemoveAll(x => x.OddOrEven(input) == true);
            Console.WriteLine();
        }
    }
}
