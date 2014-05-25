using System;
using System.Collections.Generic;
using System.Text;
using _01.RefactorCode;

public class Bowl
{
    private List<Vegetable> content;

    public Bowl()
    {
        this.content = new List<Vegetable>();
    }

    public List<Vegetable> Content
    {
        get
        {
            return new List<Vegetable>(this.content);
        }

        private set
        {
            this.content = value;
        }
    }

    public void AddContent(Vegetable vegetable)
    {
        this.content.Add(vegetable);
    }

    public void Serve()
    {
        Console.WriteLine("Served:" + Environment.NewLine + this.ToString()); 
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        foreach (var vegetable in this.Content)
        {
            result.AppendFormat("{0} and {1} {2}", vegetable.IsCut ? "Cut" : "Uncut", vegetable.IsPeeled ? "peeled" : "unpeeled", vegetable.GetType().Name);
            result.AppendLine();
        }

        return result.ToString();
    }
}
