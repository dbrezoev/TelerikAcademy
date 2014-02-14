using System;
public class Tomcat:Cat
{
    private const Sex sex = Sex.Male;
    public Tomcat(string name, int age)
        : base(name, age)
    {
        this.Sex = sex;
    }

    public override void ProduceSound()
    {
        Console.WriteLine(this.Name + " " + "says miauu I am male");
    }
}