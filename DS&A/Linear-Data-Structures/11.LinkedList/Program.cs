using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.AddFirst(5);
            list.AddAfter(list.FirstElement, -1);
            Console.WriteLine(list);
            list.AddFirst(9);
            Console.WriteLine(list);

            list.Remove(5);
            Console.WriteLine(list);
            return;
            Console.WriteLine();
            Console.WriteLine(list);
            list.AddLast(10);
            Console.WriteLine(list);
            list.AddAfter(list.FirstElement, 111);
            Console.WriteLine(list);
            list.AddAfter(list.FirstElement.NextItem, -100);
            Console.WriteLine(list);
            list.AddBefore(list.FirstElement.NextItem, 999);
            Console.WriteLine(list);
            list.AddBefore(list.FirstElement.NextItem.NextItem.NextItem, 800);
            Console.WriteLine(list);            
        }
    }
}
