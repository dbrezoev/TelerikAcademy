using System;
class Program
{
    // TASK 4
    static void Main()
    {
        //not specified age
        Person person = new Person();
        person.Name = "pesho";
        Console.WriteLine(person);

        //person with specified age
        Person secondPerson = new Person();
        secondPerson.Name = "Gosho";
        secondPerson.Age = 20;
        Console.WriteLine(secondPerson);
    }
}