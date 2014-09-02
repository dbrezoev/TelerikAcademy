namespace _03.BiDictionaryImplementation
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
            var biDict = new BiDictionary<int, string, string>();

            for (int i = 0; i < 20; i++)
            {
                var name = "Pesho" + i;
                var result = "Result" + i;
                biDict.Add(i, name, result);
            }

            var firstTry = biDict.FindByFirstKey(1);
            foreach (var item in firstTry)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            var secondTry = biDict.FindBySecondKey("Pesho2");
            foreach (var item in secondTry)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            var thirdTry = biDict.FindByTwoKeys(2, "Pesho2");
            foreach (var item in thirdTry)
            {
                Console.WriteLine(item);
            }
        }
    }
}
