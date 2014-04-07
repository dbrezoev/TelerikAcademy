using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
/*We are given the following sequence:
S1 = N;
S2 = S1 + 1;
S3 = 2*S1 + 1;
S4 = S1 + 2;
S5 = S2 + 1;
S6 = 2*S2 + 1;
S7 = S2 + 2;
...
Using the Queue<T> class write a program to print its first 50 members for given N.
Example: N=2  2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
*/
namespace _9.SequenceInQueue
{
    class SequenceInQueue
    {
        static int DoStepOne(int n)
        {
            return n + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();
            queue.Enqueue(n);
            var result = new List<int>();
            result.Add(n);
            int count = 1;
            while (count<50)
            {
                int current = queue.Dequeue();                
                result.Add(current + 1);
                result.Add(2 * current + 1);
                result.Add(current + 2);
                count+=3;
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }
            int indexToRemove = result.Count - 1;
            result.RemoveAt(indexToRemove);
            result.RemoveAt(indexToRemove - 1);
            Console.WriteLine(string.Join(", ",result));
            Console.WriteLine(result.Count);
        }
    }
}
