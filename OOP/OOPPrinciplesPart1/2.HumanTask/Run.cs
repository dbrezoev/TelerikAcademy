using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Run
{
    static void Main()
    {        
        List<Student> students = new List<Student>();
        students.Add(new Student("Pesho","Goshev",10));
        students.Add(new Student("Vlado", "Kirev", 3));
        students.Add(new Student("Dimo", "Petrov", 2));
        students.Add(new Student("Blagoi", "Toshkov", 1));
        students.Add(new Student("Minka", "Minkova", 11));
        students.Add(new Student("Dimitar", "Penev", 10));
        students.Add(new Student("Boris", "Tonev", 8));
        students.Add(new Student("Tisho", "Goshev", 7));
        students.Add(new Student("Mariq", "Simeonova", 4));
        students.Add(new Student("Kircho", "Kirchev", 4));

        var sortedByGrade = students.OrderBy(st => st.Grade).ThenBy(st => st.FirstName);
        foreach (var student in sortedByGrade)
        {
            Console.WriteLine(student.FirstName + ' ' + student.LastName+ ' ' + student.Grade);
        }

        List<Worker> workers = new List<Worker>()
        {
            new Worker("Petar", "Ivanov", 300),
            new Worker("Alexander", "Hristov", 280),
            new Worker("Simeon", "Iankov", 430),
            new Worker("Geno", "Mateev", 360),
            new Worker("Boqn", "Bqnov", 500),
            new Worker("Dimitar", "Manolov", 560),
            new Worker("Dimitar", "Mutafchiev", 409),
            new Worker("Nikola", "Mutafchiev", 444),
            new Worker("Konstantin", "Maznikov", 467),
            new Worker("Kiril", "Iovovich", 415),
        };

        Console.WriteLine(new string('-',40));
        var sortedByMoneyPerHour = workers.OrderBy(w => w.MoneyPerHour());
        foreach (var worker in sortedByMoneyPerHour)
        {
            Console.WriteLine(worker.FirstName+' ' + worker.LastName+' '+worker.MoneyPerHour());
        }
        Console.WriteLine(new string('-',40));
        var mergedList = new List<Human>(students.Count + workers.Count);
        mergedList.AddRange(students);
        mergedList.AddRange(workers);

        var sortedMergedList = mergedList.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
        int n = 0;
        foreach (var human in sortedMergedList)
        {
            n++;
            Console.WriteLine(n+". "+ human.FirstName+' ' + human.LastName);
        }
    }
}
