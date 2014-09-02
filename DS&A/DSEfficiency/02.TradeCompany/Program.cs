namespace _02.TradeCompany
{
    using System;
    using System.Diagnostics;
    using Wintellect.PowerCollections;

    public class Program
    {
        private static readonly Random random = new Random();
        
        static void Main()
        {
            OrderedMultiDictionary<decimal, Article> articles = new OrderedMultiDictionary<decimal, Article>(true);

            for (int i = 0; i < 100000; i++)
            {
                var randomPrice = RandomNumberBetween(10, 50);
                articles.Add(randomPrice, new Article()
                    {
                        Barcode = "000" + i,
                        Price = randomPrice,
                        Title = "Title " + i,
                        Vendor = "Vendor " + i,
                    });
            }

            var sw = new Stopwatch();
            sw.Start();
            var result = articles.Range(10, true, 20, true);
            Console.WriteLine(result.Count);
            Console.WriteLine("Time elapsed: " + sw.Elapsed);

        }
        private static decimal RandomNumberBetween(decimal minValue, decimal maxValue)
        {
            var next = (decimal)random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
    }
}
