using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _13.QueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();
            Console.WriteLine(queue.Contains(1));
        }
    }
}
