namespace TextToXMLConvert
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Linq;

    //TASK 7
    /*
     * In a text file we are given the name,
     * address and phone number of given person 
     * (each at a single line). Write a program, 
     * which creates new XML document,
     * which contains these data in structured XML format.
     */
    public class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            using (var reader = new StreamReader("text.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var word = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = word[0].Trim();
                    var adres = word[1].Trim();
                    var phone = word[2].Trim();
                    var student = new Student(name, adres, phone);
                    students.Add(student);                    
                    
                    line = reader.ReadLine();
                }

                var listOfStudents = new List<XElement>();

                foreach (var student in students)
                {
                    listOfStudents.Add(new XElement("student",
                            new XElement("name", student.Name),
                            new XElement("address", student.Address),
                            new XElement("telephone", student.Phone)));                    
                }

                XElement studentXml = new XElement("students", listOfStudents);
                studentXml.Save("students.xml");
            }
        }
    }
}
