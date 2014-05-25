using System;

public class Program
{
    public static void Cook(Potato potato)
    {
        Console.WriteLine("Cooking potatoes...");
    }

    public static void VisitCell()
    {
        Console.WriteLine("Cell visited.");
    }

    public static void Main()
    {
        //first task
        Potato potato = new Potato();
        if (potato != null)
        {
            if (potato.IsPeeled && !potato.IsRotten)
            {
                Cook(potato);
            }
        }

        //second task 
        bool shouldVisitCell = true;
        int minX = 0;
        int maxX = 10;
        int minY = 0;
        int maxY = 10;

        int x = 2;
        int y = 3;

        if (minX <= x && x <= maxX && 
            minY <= y && y <= maxY &&
            shouldVisitCell)
        {
            VisitCell();
        }

    }
}