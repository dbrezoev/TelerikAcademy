/* 
 Define classes File { string name, int size } and
 * Folder { string name, File[] files, Folder[] childFolders }
 * and using them build a tree keeping all files and folders on the hard drive
 * starting from C:\WINDOWS. Implement a method that calculates the sum of the file sizes
 * in given subtree of the tree and test it accordingly. Use recursive DFS traversal.
 */
namespace CustomFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        //Change directory with less folders to be easy to test
        private const string Path = "D:\\Photos\\OLX";

        public static void Main()
        {
            DirectoryInfo di = new DirectoryInfo(Path);
            Folder myFolder = new Folder(di.Name);

            TraverseFolders(Path, ref myFolder);
            Console.WriteLine(myFolder);
            Console.WriteLine();
        }
        
        public static Folder TraverseFolders(string path, ref Folder myFolder)
        {
            //DirectoryInfo di = new DirectoryInfo(path);
            //Folder myFolder = new Folder(di.Name);
            var subFolders = Directory.GetDirectories(path);

            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                FileInfo fi = new FileInfo(file);
                File fileToAdd = new File(fi.Name, fi.Length);
                myFolder.AddFile(fileToAdd);
            }

            foreach (var subFolder in subFolders)
            {  
                DirectoryInfo dir = new DirectoryInfo(subFolder);
                Folder folderToAdd = new Folder(dir.Name);
                myFolder.AddFolder(folderToAdd);

                TraverseFolders(subFolder, ref folderToAdd);
            }

            return myFolder;
        }

        private static File CreateFile(string file)
        {
            FileInfo fi = new FileInfo(file);
            File fileToAdd = new File(fi.Name, fi.Length);
            return fileToAdd;
        }

        private static Folder CreateFolder(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            Folder myFolder = new Folder(di.Name);
            return myFolder;
        }        
    }
}