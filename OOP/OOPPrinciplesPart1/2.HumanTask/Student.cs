using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student : Human
{
    private uint grade;

    public uint Grade
    {
        get
        {
            return this.grade;
        }
        set
        {
            this.grade = value;
        }
    }

    public Student(string firstName, string lastName, uint grade)
        : base(firstName, lastName)
    {
        this.Grade = grade;
    }

}
