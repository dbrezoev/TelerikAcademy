using System;
using System.Text;
public struct Point3D
{
    private static readonly Point3D startOfCoordSystem;
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
   
    
    //constructor
    public Point3D(double x, double y, double z):this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public static Point3D StartOfCoordSystem
    {
        get
        {
            return startOfCoordSystem;
        }        
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(string.Format("Point 3D: X = {0:F2}, Y = {1:F2}, Z = {2:F2}", this.X, this.Y, this.Z));
        return sb.ToString();
    }
}