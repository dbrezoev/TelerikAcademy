using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashedSetImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new HashedSet<int>();

            set.Add(8);
            set.Add(8);
            set.Add(133);
            Console.WriteLine(set.Count);

            var set2 = new HashedSet<int>();
            set2.Add(13);
            set2.Add(133);

            var res = set.Intersect(set2);

            Console.WriteLine(string.Join(", ", res));
        }
    }
}
