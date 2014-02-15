using System;
class Circle:Shape
{
    public double Radius { get; private set; }

    public Circle(double radius):base(radius)
    {
        this.Radius = base.Width;
    }
    public override double CalculateSurface()
    {
        return Math.PI * (this.Width * this.Width);
    }
}