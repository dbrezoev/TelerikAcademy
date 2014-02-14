using System;
using System.Media;
class Dog
{
    public string Name { get; private set; }
    public int Age { get; set; }

    public Dog(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void Bark()
    {
        var sound = new SoundPlayer(@"bark.wav");        
        sound.PlaySync();        
    }
}
class Program
{    
    static void Main(string[] args)
    {
        Dog dog = new Dog("pesho", 5);
        dog.Bark();
    }
}