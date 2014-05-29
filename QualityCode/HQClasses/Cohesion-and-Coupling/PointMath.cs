namespace CohesionAndCoupling
{
    using System;

    public static class PointMath
    {
        public static double GetDistance(Point2D first, Point2D second)
        {
            double distance = Math.Sqrt((second.X - first.X) * (second.X - first.X) +
                (second.Y - first.Y) * (second.Y - first.Y));

            return distance;
        }

        public static double GetDistance(Point3D first, Point3D second)
        {
            double distance = Math.Sqrt((second.X - first.X) * (second.X - first.X) +
                (second.Y - first.Y) * (second.Y - first.Y) +
                (second.Z - first.Z) * (second.Z - first.Z));

            return distance;
        }
    }
}
