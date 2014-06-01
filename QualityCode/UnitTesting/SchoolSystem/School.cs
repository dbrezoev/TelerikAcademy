namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    
    public class School
    {
        public static void Main(string[] args)
        {
            //Student pesho = new Student("Pesho");
            //Console.WriteLine(pesho.Number);
            //Student gosho = new Student("Gosho");
            //Console.WriteLine(gosho.Number);
            //Student vlado = new Student("Vlado");
            //Console.WriteLine(vlado.Number);
            //Student kiro = new Student("Kiro");
            //Console.WriteLine(kiro.Number);
            //Student simo = new Student("Simo");
            //Console.WriteLine(simo.Number);


            //List<Student> students = new List<Student>();
            //students.Add(pesho);
            //students.Add(gosho);
            //students.Add(vlado);



            List<Student> students = new List<Student>();
            var student = new Student("Pesho");
            students.Add(student);
            Course course = new Course(students);
            course.Leave(student);
            Console.WriteLine();
        }
    }
}
