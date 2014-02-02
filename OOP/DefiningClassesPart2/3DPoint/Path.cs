using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Path
{
    private List<Point3D> sequence;

    //constructor
    public Path()
    {
        this.sequence = new List<Point3D>(); // or use inline initalization?
    }
    //property
    public List<Point3D> Sequence
    {
        get
        {
            return new List<Point3D>(this.sequence);
        }
        set
        {
            this.sequence = value;
        }
    }
    public void ClearPath()
    {
        this.sequence.Clear();
    }

    public void AddPoint(Point3D point)
    {
        this.sequence.Add(point);
    }
}