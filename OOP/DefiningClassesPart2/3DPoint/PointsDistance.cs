using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class PointsDistance
{
    public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
    {
        Point3D result = new Point3D();
        result.X = secondPoint.X - firstPoint.X;
        result.Y = secondPoint.Y - firstPoint.Y;
        result.Z = secondPoint.Z - firstPoint.Z;
        double distance = Math.Sqrt(result.X * result.X + result.Y * result.Y + result.Z * result.Z);
        return distance;
    }
}