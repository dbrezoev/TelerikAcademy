using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {           
            Animal[] animals = new Animal[10]
            {
                new Tomcat("TOM",4),
                new Kitten("Kitty",3),
                new Frog("Froggy",5,Sex.Male),
                new Tomcat("Tommy",5),
                new Dog("Snoopy",8,Sex.Male),
                new Dog("Vihren",4,Sex.Male),
                new Dog("Popi",2,Sex.Male),
                new Frog("Kika",3,Sex.Female),
                new Kitten("Kotka",4),
                new Tomcat("Zver",1),
            };

            var dogsAvgAge = animals.Where(a => a is Dog == true).Average(a => a.Age);
            Console.WriteLine("Average age of all Dogs is {0:0.00} years", dogsAvgAge);

            var catsAvgAge = animals.Where(c => c is Cat == true).Average(c => c.Age);
            Console.WriteLine("Average age of all Cats is {0:0.00} years", catsAvgAge);

            var frogsAvgAge = animals.Where(f => f is Frog == true).Average(f => f.Age);
            Console.WriteLine("Average age of all Frogs is {0:0.00} years", frogsAvgAge);

            //everybody sing
            foreach (ISound animal in animals)
            {
                animal.ProduceSound();
            }
           
        }
    }
}
