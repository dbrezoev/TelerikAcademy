using System;
using System.Collections.Generic;


class School
{
    private List<Class> classes = new List<Class>();

    public List<Class> Classes
    {
        get
        {
            return new List<Class>(this.classes);
        }
        set
        {
            this.classes = value;
        }
    }
}