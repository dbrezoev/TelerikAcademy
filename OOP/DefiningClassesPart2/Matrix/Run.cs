using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Run
{
    private const int limit = 10;
    private string separator = new string('-', 40);
    private static Random rand = new Random();
    public static double GetRandomDouble(double min, double max)
    {
        return Run.rand.NextDouble() * (max - min) + min;
    }
    static void Main(string[] args)
    {
        //fill two random matrix [2,2] (easy to calculate)
        Matrix<double> matrix = new Matrix<double>(2, 2);
        Matrix<double> matrix2 = new Matrix<double>(2, 2);

        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                matrix[row, col] = Run.GetRandomDouble(0.0, 11.0);
                matrix2[row, col] = Run.GetRandomDouble(0.0, 11.0);
            }
        }
        Console.WriteLine(matrix);
        Console.WriteLine(new string('-', 40));

        Console.WriteLine(matrix2);
        Console.WriteLine(new string('-', 40));

        Console.WriteLine(matrix + matrix2);
        Console.WriteLine(new string('-', 40));

        Console.WriteLine(matrix - matrix2);
        Console.WriteLine(new string('-', 40));

        Console.WriteLine(matrix * matrix2);
        Console.WriteLine(new string('-', 40));

        if (matrix)
        {
            Console.WriteLine("No zeros in it!");
        }
        else
        {
            Console.WriteLine("There is a zero in it");
        }
    }
}