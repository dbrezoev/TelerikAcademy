namespace _02.LargeCollection
{
    using System;
    using System.Diagnostics;
    using Wintellect.PowerCollections;
    /*
     * Write a program to read a large collection of products (name + price)
     * and efficiently find the first 20 products in the price range [a…b].
     * Test for 500 000 products and 10 000 price searches.
     */
    public class Program
    {
        private const decimal MinPrice = 10;
        private const decimal MaxPrice = 99;
        private const int ProductsCount = 500000;
        private static readonly Random random = new Random();        

        static void Main()
        {
            var sw = new Stopwatch();
            sw.Start();
            var products = new OrderedBag<Product>();
            Console.WriteLine("Initialization for: " + sw.Elapsed);
            sw.Restart();

            for (int i = 0; i < ProductsCount; i++)
            {
                var name = "Product" + i;
                decimal randomPrice = RandomNumberBetween(0, 120);
                var product = new Product(name, randomPrice);
                products.Add(product);
            }
            Console.WriteLine("Fill data for: " + sw.Elapsed);
            sw.Restart();
            var result = products.Range(new Product("", MinPrice), true, new Product("", MaxPrice), true);

            Console.WriteLine(result.Count);
            Console.WriteLine("Time for made the range: " + sw.Elapsed);            
        }

        private static decimal RandomNumberBetween(decimal minValue, decimal maxValue)
        {
            var next = (decimal)random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
    }
}
