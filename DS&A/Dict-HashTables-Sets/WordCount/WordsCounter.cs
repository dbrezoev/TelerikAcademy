namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class WordsCounter
    {
        static void Main()
        {            
            var result = new SortedDictionary<string, int>();

            using (var reader = new StreamReader("text.txt"))
            {
                string line = reader.ReadLine();
                var words = line.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    var wordToLower = word.ToLower();
                    if (!result.ContainsKey(wordToLower))
                    {
                        result.Add(wordToLower, 1);
                    }

                    result[wordToLower]++;
                }
            }

            foreach (var item in result.OrderBy(w => w.Value))
            {
                Console.WriteLine(item.Key + "->" + item.Value + "times");
            }
        }
    }
}
