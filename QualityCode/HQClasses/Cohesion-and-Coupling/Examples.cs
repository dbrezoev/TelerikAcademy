using System;

namespace CohesionAndCoupling
{
    class Examples
    {
        static void Main()
        {
            Console.WriteLine(FileWorker.GetFileExtension("example.new.pdf"));           
            Console.WriteLine(FileWorker.GetFileName("example.pdf"));

            var firstPoint = new Point2D(0, 10);
            var secondPoint = new Point2D(15, 15);
            var distance = PointMath.GetDistance(firstPoint, secondPoint);
            Console.Write("Distance between two points 2D: ");
            Console.WriteLine("{0:f2}", distance);

            var firstPoint3D = new Point3D(0, 10, 15);
            var secondPoint3D = new Point3D(0, 0, 0);
            var distance3D = PointMath.GetDistance(firstPoint3D, secondPoint3D);
            Console.Write("Distance between two points 3D: ");
            Console.WriteLine("{0:f2}", distance3D);

            var rectangle = new Rectangle(10, 10);
            Console.Write("Diagonal of the 2d rectangle: ");
            Console.WriteLine("{0:f2}", rectangle.CalculateDiagonal());

            var cube = new Cube(10, 20, 30);
            Console.Write("Volume of the cube: ");
            Console.WriteLine("{0:f2}", cube.CalculateVolume());
            Console.WriteLine("Two of the diagonals of the cube are: ");
            Console.WriteLine("{0:f2}", cube.CalculateDiagonalXYZ());
            Console.WriteLine("{0:f2}", cube.CalculateDiagonalXZ());
        }
    }
}
