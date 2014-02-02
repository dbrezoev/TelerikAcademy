using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPoint
{
    class Program
    {
        private static string separator = new string('-',30);
        static void Main(string[] args)
        {

            //testing distance between two points
            Point3D p1 = new Point3D(10, 20, 30);
            Point3D p2 = new Point3D(); // (0,0,0) inline initialization

            double distance = PointsDistance.CalculateDistance(p1, p2);
            Console.WriteLine("Distance: {0:F2}",distance);
            Console.WriteLine(separator);

            //testing adding points to path
            Path path = new Path();
            path.AddPoint(p1);
            path.AddPoint(p2);
            path.AddPoint(Point3D.StartOfCoordSystem);
            path.AddPoint(new Point3D(5, 6, 7));
            foreach (Point3D point in path.Sequence)
            {
                Console.WriteLine(point);
            }
            Console.WriteLine(separator);

            //saving path test
            PathStorage.SavePath(path);

            Console.WriteLine(separator);

            //loading path from file test
            List<Path> list = PathStorage.LoadPaths("paths.txt");
            for (int i = 0; i < list.Count; i++)
            {
                foreach (Point3D point in list[i].Sequence)
                {
                    Console.WriteLine(point);
                }
            }                                    
        }
    }
}
