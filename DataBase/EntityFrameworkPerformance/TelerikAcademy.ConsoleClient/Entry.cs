namespace TelerikAcademy.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TelerikAcademy.Models;

    public class Entry
    {
        static void Main(string[] args)
        {
            //Too much queries

            //using (var db = new TelerikAcademyEntities())
            //{
            //    var sw = new Stopwatch();
            //    sw.Start();
            //    var employees = db.Employees;
                
            //    foreach (var employee in employees)
            //    {
            //        Console.WriteLine(employee.FirstName);
            //        Console.WriteLine(employee.Departments1.Name);
            //        Console.WriteLine(employee.Addresses.Towns.Name);
            //        Console.WriteLine("-------");
            //    }
            //    Console.WriteLine("Time: " + sw.Elapsed);
            //}

            //Faster way

            //using (var db = new TelerikAcademyEntities())
            //{
            //    var sw = new Stopwatch();
            //    sw.Start();
            //    var employees = db.Employees.Include("Addresses.Towns").Include("Departments1");
                
            //    foreach (var employee in employees)
            //    {
            //        Console.WriteLine(employee.FirstName);
            //        Console.WriteLine(employee.Departments1.Name);
            //        Console.WriteLine(employee.Addresses.Towns.Name);
            //        Console.WriteLine("-------");
            //    }

            //    Console.WriteLine(sw.Elapsed);
            //}

            //Another fast way

            //using (var db = new TelerikAcademyEntities())
            //{
            //    var sw = new Stopwatch();
            //    sw.Start();
            //    var employees = db.Employees.Select(e => new
            //    {
            //        FirstName = e.FirstName,
            //        DepartmentName = e.Departments1.Name,
            //        Town = e.Addresses.Towns.Name
            //    });

            //    foreach (var item in employees)
            //    {
            //        Console.WriteLine(item.FirstName);
            //        Console.WriteLine(item.DepartmentName);
            //        Console.WriteLine(item.Town);
            //        Console.WriteLine("-------");
            //    }

            //    Console.WriteLine(sw.Elapsed);
            //}





            //TASK2

            using (var db = new TelerikAcademyEntities())
            {
                var result = db.Employees.ToList()
                    .Select(e => e.Addresses).ToList()
                    .Select(e => e.Towns).ToList()
                    .Select(e => e.Name == "Sofia")
                    .ToList();
            }

            //using (var db = new TelerikAcademyEntities())
            //{
            //    var result = db.Employees
            //        .Select(e => e.Addresses)
            //        .Select(e => e.Towns)
            //        .Select(e => e.Name == "Sofia")
            //        .ToList();
            //}
        }
    }
}
