namespace _10._1.DirectoryTraverse
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;
    //TASK 10 
    //Same as 9 but using XElement
    public class Program
    {
        private const string DirectoryRoot = "D:\\Photos\\OLX";
        private const string ResultDirectory = "..\\..\\result.xml";

        static void Main()
        {
            XElement xdoc = new XElement("dirs");
            Traverse(DirectoryRoot, xdoc);
            xdoc.Save(ResultDirectory);
        }

        private static void Traverse(string startDirectory, XElement xdoc)
        {
            XElement inner = new XElement("dir", new XAttribute("name", startDirectory));

            try
            {
                foreach (string file in Directory.GetFiles(startDirectory))
                {
                    inner.Add(new XElement("file", file));
                }

                foreach (string dir in Directory.GetDirectories(startDirectory))
                {
                    Traverse(dir, inner);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            xdoc.Add(inner);
        }
    }
}
