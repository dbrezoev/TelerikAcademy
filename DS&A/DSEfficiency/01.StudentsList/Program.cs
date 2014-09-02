namespace _01.StudentsList
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        static void Main(string[] args)
        {
            var record = new SortedDictionary<string, SortedDictionary<string, string>>();
            using (var reader = new StreamReader("students.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var words = line.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                    var firstName = words[0];
                    var lastName = words[1];
                    var course = words[2];
                    var innerSortedDict = new SortedDictionary<string, string>();
                    innerSortedDict.Add(lastName, firstName);
                    if (!record.ContainsKey(course))
                    {
                        record.Add(course, innerSortedDict);
                    }
                    else
                    {
                        record[course].Add(lastName, firstName);
                    }
                    
                    line = reader.ReadLine();
                }
            }

            foreach (var course in record)
            {
                Console.Write(course.Key + " : ");

                foreach (var student in course.Value)
                {                    
                    Console.Write(student.Value + " " + student.Key + ", ");
                }

                Console.WriteLine();
            }

        }
    }
}
