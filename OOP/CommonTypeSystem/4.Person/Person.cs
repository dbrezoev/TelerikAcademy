using System;
using System.Text;
public class Person
{
    private uint? age;
    private string name;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            if (value.Length<3)
            {
                throw new ArgumentException("Name too short to be real");
            }
            this.name = value;
        }
    }

    public uint? Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        if (this.Name !=null)
        {
            sb.Append(this.name);
            sb.Append(" ");
        }
        if (this.age == null)
        {
            sb.Append("<age not specified>");
        }
        else
        {
            sb.Append(this.age);
        }
        return sb.ToString();
    }
}