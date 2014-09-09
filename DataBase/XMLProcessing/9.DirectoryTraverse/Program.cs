/*
 Write a program to traverse given directory and write to a XML file
 * its contents together with all subdirectories and files.
 * Use tags <file> and <dir> with appropriate attributes.
 * For the generation of the XML document use the class XmlWriter.
 */
namespace _9.DirectoryTraverse
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    public class Program
    {
        private const string DirectoryRoot = "D:\\Photos\\OLX";
        private const string ResultDirectory = "..\\..\\result.xml";

        static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter(ResultDirectory, Encoding.GetEncoding("windows-1251")))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();

                Traverse(DirectoryRoot, writer);
            }
        }

        private static void Traverse(string startDirectory, XmlWriter writer)
        { 
            try
            {                 
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("name", startDirectory);
 
                foreach (string file in Directory.GetFiles(startDirectory))
                {
                    writer.WriteElementString("file", file);                    
                }
                
                foreach (string dir in Directory.GetDirectories(startDirectory))
                {                   
                    Traverse(dir, writer);
                }
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }    

            writer.WriteEndElement();
        }
    }
}
