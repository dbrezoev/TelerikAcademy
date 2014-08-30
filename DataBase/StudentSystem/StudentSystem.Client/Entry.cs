namespace StudentSystem.Client
{
    using StudentSystem.Data;
    using System;
    using System.Collections.Generic;
    using StudentSystem.Models;
    using System.Data.Entity;
    using StudentSystem.Data.Migrations;

    public class Entry
    {
        static void Main()
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<StudentSystemContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());

            StudentSystemContext dbContext = new StudentSystemContext();

            var student = new Student()
            {
                Name = "Gosho",
                Number = "15",
                Courses = new HashSet<Course>()
                {
                    new Course()
                    {
                        Name = "Entity Framework",
                        Description = "Entity Framework Entity Framework Entity Framework Entity Framework ",
                        Material = "Data base miracles Data base miracles Data base miracles",                        
                    }
                },
            };

            dbContext.Students.Add(student);
            Console.WriteLine("Student added.");

            //var students = dbContext.Students.Where(s => s.Name == "Pesho");
            //Console.WriteLine(student.Name);

            dbContext.SaveChanges();
        }
    }
}
