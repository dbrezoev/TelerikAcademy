using System;
//TASK 1, TASK 2, TASK 3
class Program
{
    static void Main(string[] args)
    {
        Student first = new Student();
        first.FirstName = "Pesho";

        Student second = new Student();
        second.FirstName = "gosho";

        Console.WriteLine(first==second); // False

        Student cloned = (Student)first.Clone();
        Console.WriteLine(first==cloned);// true

        Console.WriteLine(first!=null); // true
        
        //add more class members
        first.LastName = "Stoyanov";
        first.SSN = "16445";
        first.University = University.SoftUni;
        first.Faculty = Faculty.FacultyOfInformatics;
        first.Specialty = Specialty.Informatics;

        Console.WriteLine(first);

    }
}