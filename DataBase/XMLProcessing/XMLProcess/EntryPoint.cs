namespace XMLProcess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;
  
    public class EntryPoint
    {
        private const string FilePath = "..\\..\\catalogue.xml";
        private const string FilePathAlbum = "..\\..\\albums.xml";
        private const decimal PriceToDelete = 20;

        static void Main()
        {
            //TASK2
            /*
             * Write program that extracts all different artists which are found in the catalog.xml. 
             * For each author you should print the number of albums in the catalogue. Use the DOM parser and a hash-table.
             */
            XmlDocument doc = new XmlDocument();
            doc.Load(FilePath);
            var rootNode = doc.DocumentElement;
            var artists = new Dictionary<string, int>();
            foreach (XmlNode child in rootNode.ChildNodes)
            {
                string artistName = child["artist"].InnerText;
                RecordArtist(artists, artistName);   
            }

            Console.WriteLine("Using DOM Parser: ");
            PrintArtists(artists);

            //TASK3
            //Implement the previous using XPath.

            var artistsDict = new Dictionary<string, int>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(FilePath);
            string query = "/catalogue/album";
            XmlNodeList artistsList = xmlDoc.SelectNodes(query);
            foreach (XmlNode item in artistsList)
            {
                string artistName = item.SelectSingleNode("artist").InnerText;
                RecordArtist(artistsDict, artistName);
            }

            Console.WriteLine("Using XPath: ");
            PrintArtists(artistsDict);

            //Task4
            //Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(FilePath);
            var root = xmlDocument.DocumentElement;
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                var currentItem = root.ChildNodes[i];
                decimal albumPrice = decimal.Parse(currentItem["price"].InnerText);
                if (albumPrice > PriceToDelete)
                {
                    root.RemoveChild(currentItem);
                    i--;
                }
            }            

            xmlDocument.Save("..\\..\\Albums-Under-20-price.xml");

            //Task5
            //Write a program, which using XmlReader extracts all song titles from catalog.xml.

            Console.WriteLine();
            Console.WriteLine("Extracting songs titles with XMLReader...");
            Console.WriteLine();
            using (XmlReader reader = XmlReader.Create(FilePath))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {                        
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }

            //Task6
            //Rewrite the same using XDocument and LINQ query

            Console.WriteLine();
            Console.WriteLine("Extracting songs titles with XDocument...");
            Console.WriteLine();
            XDocument xDoc = XDocument.Load(FilePath);            

            var songs =
                from song in xDoc.Descendants("song")
                where song.Element("title").Value != null
                select new
                {
                    Title = song.Element("title").Value,
                };

            foreach (var song in songs)
            {
                Console.WriteLine(song.Title);
            }

            //TASK8
            /*
             * Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml and
             * creates the file album.xml, in which stores in appropriate way the names of all albums and their authors.
             */

            Encoding encoding = Encoding.GetEncoding("windows-1251");
            using (XmlReader reader = XmlReader.Create(FilePath))
            {
                using (XmlTextWriter writer = new XmlTextWriter(FilePathAlbum, encoding))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = '\t';
                    writer.Indentation = 1;

                    writer.WriteStartDocument();
                    writer.WriteStartElement("albums");

                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "name"))
                        {
                            writer.WriteStartElement("album"); 
                            writer.WriteElementString("name", reader.ReadElementString()); 
                        }
                        else if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "producer"))
                        {
                            writer.WriteElementString("artist", reader.ReadElementString());
                            writer.WriteEndElement(); 
                        }                        
                    }
                }                
            }


        }       

        private static void PrintArtists(Dictionary<string, int> artists)
        {
            foreach (var item in artists)
            {
                Console.WriteLine(item.Key + "-->" + item.Value);
            }
        }

        private static void RecordArtist(Dictionary<string, int> artists, string artistName)
        {
            if (!artists.ContainsKey(artistName))
            {
                artists.Add(artistName, 1);
            }
            else
            {
                artists[artistName]++;
            }
        }
    }
}
