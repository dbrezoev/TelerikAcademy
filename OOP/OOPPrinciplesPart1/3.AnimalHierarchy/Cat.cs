using System;
public abstract class Cat:Animal,ISound
{
    public Cat(string name, int age):this(name,age,Sex.Male)
    {
    }
    public Cat(string name, int age, Sex sex):base(name,age,sex)
    {
    }

    //public abstract void ProduceSound();    
}