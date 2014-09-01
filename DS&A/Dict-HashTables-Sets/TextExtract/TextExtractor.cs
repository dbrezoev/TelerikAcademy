namespace TextExtract
{
    /*
    Write a program that extracts from a given sequence of strings all
    elements that present in it odd number of times. Example:
    {C#, SQL, PHP, PHP, SQL, SQL }  {C#, SQL}
     */
    using System;
    using System.Collections.Generic;
   // using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TextExtractor
    {
        private const string text = "C#, SQL, PHP, PHP, SQL, SQL";
        static void Main()
        {
            
            
            var words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                if (!result.ContainsKey(currentWord))
                {
                    result.Add(currentWord, 0);
                }

                result[currentWord]++;
            }

            foreach (var item in result)
            {
                if (item.Value % 2 == 1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
