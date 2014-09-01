using System;
using System.Collections.Generic;
using System.Text;
namespace CustomFile
{
    public class Folder : IFileSystemEntity
    {
        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public string Name { get; set; }

        public List<File> Files { get; set; }

        public List<Folder> ChildFolders { get; set; }

        public void AddFolder(Folder newFolder)
        {
            if (newFolder == null)
            {
                throw new ArgumentException("Cannot add null Folder.");
            }

            this.ChildFolders.Add(newFolder);
        }

        public void AddFile(File newFile)
        {
            if (newFile == null)
            {
                throw new ArgumentException("Cannot add null File.");
            }

            this.Files.Add(newFile);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("Folder Name: ");
            result.AppendLine(this.Name);
            result.Append("Files: ");
            foreach (var file in this.Files)
            {
                result.Append(file.ToString());
            }

            result.AppendLine("Inner Folders: ");
            foreach (var folder in this.ChildFolders)
            {
                result.Append(folder.ToString());
            }

            return result.ToString();
        }
    }
}
