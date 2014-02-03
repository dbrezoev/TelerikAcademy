using System;
class Run
{
    static void Main(string[] args)
    {
        Type type = typeof(Dog);
        object[] allAttributes = type.GetCustomAttributes(false);
        foreach (VersionAttribute attr in allAttributes)
        {
            Console.WriteLine("The class {0} is version: {1}",type,attr.Version);
        }

    }
}