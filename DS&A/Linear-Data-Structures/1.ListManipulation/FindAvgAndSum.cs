using System;
using System.Collections.Generic;
/*Write a program that reads from the console a sequence of positive integer numbers. 
 *The sequence ends when empty line is entered. Calculate and print the sum and average of the elements of the sequence.
 *Keep the sequence in List<int>.
*/
namespace _1.ListManipulation
{
    class FindAvgAndSum
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string input = Console.ReadLine();
            while (true)
            {
                if (!string.IsNullOrEmpty(input))
                {
                    list.Add(int.Parse(input));
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            int sum = 0;
            float avg = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            avg = (float)sum / list.Count;
            Console.WriteLine("Sum: {0}",sum);
            Console.WriteLine("Average: {0}",avg);
        }
    }
}
