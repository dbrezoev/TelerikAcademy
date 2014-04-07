using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.
*/
namespace _2.ReverseNumbers
{
    class ReverseNums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many number do you want to enter: ");
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                stack.Push(number);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            
        }
    }
}
