using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableImplementation
{
    class Program
    {
        static void Main(string[] args)
        {            
            var hash = new HashTable<string, int>();

            for (int i = 0; i < 50; i++)
            {
                var name = "Pesho";
                hash.Add(name + i, i);
                Console.WriteLine("Count: " + hash.Count);
                Console.WriteLine("Length: " + hash.Length);

            }
           
            var result = hash.Find("Pesho4");
            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("Count is " + hash.Count);
            hash.Remove("Pesho2");
            Console.WriteLine("Now count is " + hash.Count);

            Console.WriteLine("-------");

            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
