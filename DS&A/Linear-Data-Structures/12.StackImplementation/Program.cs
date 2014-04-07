using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _12.StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(9);
            stack.Push(10);
            stack.Pop();
            Console.WriteLine(stack.Contains(10));            
        }
    }
}
