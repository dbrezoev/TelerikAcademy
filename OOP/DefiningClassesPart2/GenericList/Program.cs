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
        string max = generic.Max();
        Console.WriteLine(max);
        return;
        //GenericList<string> generic = new GenericList<string>(2);
        //generic.AddElement("Pesho");
        //generic.AddElement("Gosho");
        //Console.WriteLine(generic);
        
        //generic.InsertAtIndex("Gosho", 0);
        //Console.WriteLine(generic);
        
        //generic.AddElement("Kircho");
        //Console.WriteLine(generic);
        
        //Console.WriteLine(generic);
        //generic.InsertAtIndex("Jivko", 0);
        //Console.WriteLine(generic);
        //generic.InsertAtIndex("Toshko", 1);
        //Console.WriteLine(generic);
        //generic.RemoveAtIndex(0);
        //Console.WriteLine(generic);
        //Console.WriteLine(generic.FindElement("Gosho"));
        ////generic.ClearArray();
        //Console.WriteLine(generic);
       
        //generic[5] = "Tihomir";
        //Console.WriteLine(generic);
        
        //Console.WriteLine(generic[0]);
        //Console.WriteLine(generic[generic.Length-1]);
    }
}