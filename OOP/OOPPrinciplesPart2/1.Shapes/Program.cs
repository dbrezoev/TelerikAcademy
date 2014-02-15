using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {        
        Shape[] shapes = new Shape[]
        {
            new Circle(5.5),
            new Triangle(5,4.5),
            new Rectangle(5,4),
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("The {0} has surface: {1:0.00}",shape.GetType(),shape.CalculateSurface());
        }
    }
}