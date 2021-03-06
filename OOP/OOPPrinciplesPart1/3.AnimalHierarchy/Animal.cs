﻿using System;

public abstract class Animal:ISound
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public Sex Sex { get; set; }    

    public Animal(string name, int age, Sex sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public abstract void ProduceSound();
    
}