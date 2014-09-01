namespace _02.TraverseWindows
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    //Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively
    //and to display all files matching the mask *.exe. Use the class System.IO.Directory.
   

    public class Program
    {
        private  static HashSet<string> resultFiles = new HashSet<string>();
        static void Main(string[] args)
        {
            string startDirectory = @"C:\\Windows\";

            DFS(startDirectory);

            Console.Write(string.Join(Environment.NewLine, resultFiles));
        }
        private static void DFS(string startDirectory)
        {
            try
            {
                foreach (string file in Directory.GetFiles(startDirectory))
                {
                    if (file.EndsWith(".JPG"))
                    {
                        resultFiles.Add(file);
                    }
                }

                foreach (string dir in Directory.GetDirectories(startDirectory))
                {
                    DFS(dir);
                }
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
