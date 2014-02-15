using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Shape
{
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Shape(double width)
    {
        this.Width = width;
        this.Height = width;
    }

    public Shape(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public abstract double CalculateSurface();
}
