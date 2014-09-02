namespace _01.PriorityQueueViaBinaryHeap
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            var queue = new PriorityQueue<int>();

            queue.Enqueue(4);
            queue.Enqueue(1);
            queue.Enqueue(31);
            queue.Enqueue(-34);
            queue.Enqueue(0);

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            
        }
    }
}
