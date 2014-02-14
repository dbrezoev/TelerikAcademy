using System;
public class Tomcat:Cat
{
    //private const Sex sex = Sex.Male;
    public Tomcat(string name, int age)
        : base(name, age,Sex.Male)
    {        
    }

    public override void ProduceSound()
    {
        Console.WriteLine(this.Name + " " + "says miauu I am male");
    }
}