namespace _11.PriceExtract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;
    /*
     * Write a program, which extract from the file catalog.xml 
     * the prices for all albums, published 5 years ago or earlier.
     * Use XPath query.
     */

    public class Program
    {
        private const string FilePath = "..\\..\\catalogue.xml";


        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(FilePath);
            string query = "/catalogue/album";

            XmlNodeList albums = xmlDoc.SelectNodes(query);
            foreach (XmlNode item in albums)
            {
                string price = item.SelectSingleNode("price").InnerText;
                int albumCreatedOn = int.Parse(item.SelectSingleNode("year").InnerText);
                int currentYear = int.Parse(DateTime.Now.Year.ToString());
                if (currentYear - 5 < albumCreatedOn)
                {
                    Console.WriteLine("Prices to albums for the past 5 years: ");
                    Console.WriteLine(price);
                }
            }

            //TASK 12
            //Same using LINQ
            Console.WriteLine();
            Console.WriteLine("Using LINQ: ");
            XDocument document = XDocument.Load(FilePath);

            var result =
                from album in document.Descendants("album")
                where int.Parse(album.Element("year").Value) + 5 > int.Parse(DateTime.Now.Year.ToString())
                select new
                {
                    Price = album.Element("price").Value,
                };

            foreach (var price in result)
            {
                Console.WriteLine(price);
            }
            
        }
    }
}
