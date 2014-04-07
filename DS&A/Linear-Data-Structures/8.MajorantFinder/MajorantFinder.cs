using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/** The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
 * Write a program to find the majorant of given array (if exists). Example:
{2, 2, 3, 3, 2, 3, 4, 3, 3}  3
*/
class MajorantFinder
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 2,3,4};
        var dictionary = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            int currenNumber = arr[i];
            int value;
            if (!dictionary.TryGetValue(currenNumber, out value))
            {
                dictionary.Add(currenNumber, 1);
            }
            else
            {
                dictionary[currenNumber]++;
            }
        }
        var hasMajorant = false;
        foreach (var item in dictionary)
        {
            if (item.Value > arr.Length / 2)
            {
                Console.WriteLine("Majorant " + item.Key);
                hasMajorant = true;
            }            
        }

        if (!hasMajorant)
        {
            Console.WriteLine("No majorant!");
        }
    }
}
