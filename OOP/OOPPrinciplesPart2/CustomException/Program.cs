using System;
using System.Globalization;

public class Program
{    
    static void Main()
    {
        NumbersMethod();

        DateTimeMethod();

    }

    private static void NumbersMethod()
    {
        int min = 1;
        int max = 100;
        Console.WriteLine("Enter a number between {0} and {1}", min, max);
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 100)
        {
            throw new InvalidRangeException<int>("Not in range", min, max);
        }
    }

    private static void DateTimeMethod()
    {
        DateTime min = new DateTime(1980, 1, 1);
        DateTime max = DateTime.Today;

        Console.WriteLine("Enter a valid Date between {0} and {1}",min.ToString("d.M.yyyy"),max.ToString("d.M.yyyy"));
        string input = Console.ReadLine();
        DateTime dateTime = DateTime.ParseExact(input, "d.M.yyyy", CultureInfo.InvariantCulture);
        if (dateTime< min || dateTime>max)
        {
            throw new InvalidRangeException<DateTime>("Date not in range", min, max);
        }
    }
}
