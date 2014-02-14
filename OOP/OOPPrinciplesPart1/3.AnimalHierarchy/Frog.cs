using System;
public class Frog:Animal
{

    public Frog(string name, int age, Sex sex):base(name,age,sex)
    {
    }
    public override void ProduceSound()
    {
        Console.WriteLine(this.Name + " says kvak");
    }
}
