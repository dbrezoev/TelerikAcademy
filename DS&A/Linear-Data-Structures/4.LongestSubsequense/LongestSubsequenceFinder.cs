using System;
using System.Collections.Generic;
/*Write a method that finds the longest subsequence of equal numbers in given List<int>
 * and returns the result as new List<int>.
 * Write a program to test whether the method works correctly*/
namespace _4.LongestSubsequense
{
    class LongestSubsequenceFinder
    {
        static List<int> FindSequence(List<int> input)
        {
            var dictionary = new Dictionary<int, List<int>>();
            int max = 1;
            for (int i = 0; i < input.Count; i++)
            {
                int currentNumber = input[i];
                var list = new List<int>();
                if (!dictionary.ContainsKey(currentNumber))
                {
                    list.Add(currentNumber);
                    dictionary.Add(currentNumber, list);
                }
                else
                {
                    dictionary[currentNumber].Add(currentNumber);

                    if (dictionary[currentNumber].Count > max)
                    {
                        max = currentNumber;
                    }
                }
            }

            List<int> result = dictionary[max];

            return result;
        }
        static void Main(string[] args)
        {            
            var input = new List<int>{ 1, 2, 2, 2, 3, 2, 4, 5,5,5,5, 7, 8};            

            var result = LongestSubsequenceFinder.FindSequence(input);

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
