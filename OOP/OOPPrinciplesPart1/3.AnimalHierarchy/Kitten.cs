using System;
public class Kitten:Cat
{
    private const Sex sex = Sex.Female;
    public Kitten(string name, int age):base(name,age)
    {
        this.Sex = sex;
    }
    public override void ProduceSound()
    {
        Console.WriteLine(this.Name + " "+ "says miau I am female");
    }
}