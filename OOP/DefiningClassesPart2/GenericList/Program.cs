using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        GenericList<string> generic = new GenericList<string>(2);
        generic.AddElement("Pesho");
        generic.AddElement("Gosho");
        generic.AddElement("Kircho");
        Console.WriteLine(generic);
        string max = generic.Max();
        Console.WriteLine(max);

        generic.InsertAtIndex("Vlado", 0);
        generic.InsertAtIndex("Drago", 0);
        Console.WriteLine(generic);
        generic.ClearArray();
        Console.WriteLine(generic);
        
        //unit test one folder back
    }
}