using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Class
{
    private string textIdentifier;
    private List<Teacher> teachers = new List<Teacher>();

    public string TextIdentifier
    {
        get
        {
            return this.textIdentifier;
        }
        set
        {
            this.textIdentifier = value;
        }
    }

    public List<Teacher> Teachers
    {
        get
        {
            return new List<Teacher>(this.teachers);
        }
        set
        {
            this.teachers = value;
        }
    }
    public static void Main()
    {
    }
}