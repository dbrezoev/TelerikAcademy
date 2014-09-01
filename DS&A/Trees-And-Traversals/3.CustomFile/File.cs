namespace CustomFile
{
    using System;
    using System.Text;

    public class File : IFileSystemEntity
    {
        private string name;
        private long size;

        public File(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Wrong File name.");
                }

                this.name = value;
            }
        }

        public long Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Wrong File size. It cannot be negative number.");
                }

                this.size = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("Name: " + this.Name);

            return result.ToString();
        }
    }
}
