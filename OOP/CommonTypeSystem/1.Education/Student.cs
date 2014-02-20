using System;
using System.Collections.Generic;
using System.Text;
public class Student:ICloneable,IComparable<Student>
{    
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string SSN { get; set; }
    public string Address { get; set; }
    public string MobilePhone { get; set; }
    public string Course { get; set; }
    public University University { get; set; }
    public Faculty Faculty { get; set; }
    public Specialty Specialty { get; set; }
    

    public override bool Equals(object obj)
    {
        if (!(obj is Student))
        {
            return false;
        }
        Student student = (Student)obj;
        if (!Object.Equals(this.FirstName,student.FirstName))
        {
            return false;
        }
        if (!Object.Equals(this.MiddleName,student.MiddleName))
        {
            return false;
        }
        if (!Object.Equals(this.LastName,student.LastName))
        {
            return false;
        }
        if (!Object.Equals(this.Address,student.Address))
        {
            return false;
        }
        if (!Object.Equals(this.MobilePhone, student.MobilePhone))
        {
            return false;
        }
        if (!Object.Equals(this.Course, student.Course))
        {
            return false;
        }
        if (!Object.Equals(this.University,student.University))
        {
            return false;
        }
        if (!Object.Equals(this.Specialty, student.Specialty))
        {
            return false;
        }
        if (!Object.Equals(this.Faculty, student.Faculty))
        {
            return false;
        }
        return true;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        var props = this.GetType().GetProperties();
        foreach (var prop in props)
        {
            sb.Append(prop.Name + ": ");
            if (!object.Equals(null,prop.GetValue(this)))
            {
                sb.AppendLine(prop.GetValue(this).ToString());
            }
            else
            {
                sb.AppendLine(string.Format("[unknown]"));
            }            
        }              
        return sb.ToString();
    }

    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() ^
            this.MiddleName.GetHashCode() ^
            this.LastName.GetHashCode() ^
            this.SSN.GetHashCode() ^
            this.Address.GetHashCode() ^
            this.MobilePhone.GetHashCode()^
            this.Course.GetHashCode() ^
            this.University.GetHashCode() ^
            this.Faculty.GetHashCode() ^
            this.Specialty.GetHashCode();
    }
    public static bool operator ==(Student student1, Student student2)
    {
        return Student.Equals(student1, student2);
    }

    public static bool operator !=(Student st1, Student st2)
    {
        return !(Student.Equals(st1, st2));
    }

    public object Clone()
    {
        Student result = new Student();
        var props = result.GetType().GetProperties();
        var thisProps = this.GetType().GetProperties();

        foreach (var prop in thisProps)
        {
            prop.SetValue(result,prop.GetValue(this));            //what about private members?
        }        
        return result;        
    }

    public int CompareTo(Student other)
    {
        List<int> list = new List<int>();
        if (this.FirstName!=null)
        {
            list.Add(this.FirstName.CompareTo(other.FirstName));
        }
        if (this.LastName!=null)
        {
            list.Add(this.LastName.CompareTo(other.LastName));
        }
        if (this.SSN!=null)
        {
            list.Add(this.SSN.CompareTo(other.SSN));
        }
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i]!=0)
            {
                return list[i];
            }
        }
        return 0;
    }
}