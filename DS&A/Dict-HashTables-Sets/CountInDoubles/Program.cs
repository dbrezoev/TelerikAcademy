namespace CountInDoubles
{
    /*
    Write a program that counts in a given array of double values the number
    of occurrences of each value. Use Dictionary<TKey,TValue>.
    */
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            var array = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            var result = new Dictionary<double, int>();

            for (int i = 0; i < array.Length; i++)
            {
                var current = array[i];
                if (!result.ContainsKey(array[i]))
                {
                    result.Add(current, 0);                   
                }
              
                result[current]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine(string.Format("{0} appear {1} times.", item.Key, item.Value));
            }
        }
    }
}
