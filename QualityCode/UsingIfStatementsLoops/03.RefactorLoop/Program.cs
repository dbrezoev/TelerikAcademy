using System;

public class Program
{
    public static void Main()
    {
        int[] array = new int[100];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }

        int expectedValue = 30;

        bool isFound = false;

        for (int i = 0; i < 100; i++)
        {
            if (i % 10 == 0 && array[i] == expectedValue)
            {
                isFound = true;
                break;
            }
        }

        Console.WriteLine(isFound ? "Found" : "Not found");
    }
}