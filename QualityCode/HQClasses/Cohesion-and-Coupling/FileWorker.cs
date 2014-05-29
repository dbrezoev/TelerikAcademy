namespace CohesionAndCoupling
{
    using System;

    public class FileWorker
    {
        public static string GetFileExtension(string fileName)
        {
            FileWorker.ValidateName(fileName);

            int indexOfLastDot = fileName.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                throw new ArgumentException("Invalid file name");
            }

            string extension = fileName.Substring(indexOfLastDot + 1);

            return extension;
        }

        public static string GetFileName(string fileName)
        {
            FileWorker.ValidateName(fileName);

            int indexOfLastDot = fileName.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);

            return extension;
        }

        private static void ValidateName(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("Filename is null.");
            }

            if (fileName == string.Empty)
            {
                throw new ArgumentException("Empty filename.");
            }
        }
    }
}
