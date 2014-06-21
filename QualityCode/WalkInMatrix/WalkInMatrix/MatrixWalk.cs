using System;

public class WalkInMatrix
{   
    private static int n;
    private static int[,] matrix;
    private static int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
    private static int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

    public static void ChangeDirection(ref int currentDirectionX, ref int currentDirectionY)
    {       
        int currentDirection = 0;

        for (int index = 0; index < dirX.Length; index++)
        {
            if (dirX[index] == currentDirectionX && dirY[index] == currentDirectionY)
            { 
                currentDirection = index;
                break; 
            }
        }

        if (currentDirection == dirX.Length - 1)
        {
            currentDirectionX = dirX[0]; 
            currentDirectionY = dirY[0]; 

            return; 
        }

        currentDirectionX = dirX[currentDirection + 1];
        currentDirectionY = dirY[currentDirection + 1];
    }    

    public static void FindCell(int[,] matrix, out int x, out int y)
    {
        x = 0;
        y = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                if (matrix[row, col] == 0)
                {
                    x = row;
                    y = col;
                    return;
                }
            }
        }
    }

    public static void Main()
    {
        n = GetInputData();
        matrix = GenerateMatrix(n);
        PrintMatrix(matrix);
    }

    public static int[,] GenerateMatrix(int n)
    {
        int[,] resultMatrix = new int[n, n];
        
        int fillNumber = 1;
        int col = 0; 
        int row = 0;
        
        FillMatrix(n, resultMatrix, ref fillNumber, ref col, ref row);

        FindCell(resultMatrix, out col, out row);

        if (col == 0 && row == 0)
        {
            return resultMatrix;
        }

        FillMatrix(n, resultMatrix, ref fillNumber, ref col, ref row);

        return resultMatrix;
    }

    private static void FillMatrix(int n, int[,] matrix, ref int number, ref int col, ref int row)
    {
        int currentDirectionX = 1;
        int currentDirectionY = 1;

        while (true)
        { 
            matrix[col, row] = number;

            if (!CheckDirection(matrix, col, row))
            {
                break;
            }

            if (col + currentDirectionX >= n || col + currentDirectionX < 0 ||
                row + currentDirectionY >= n || row + currentDirectionY < 0 ||
                matrix[col + currentDirectionX, row + currentDirectionY] != 0)
            {
                while (col + currentDirectionX >= n || col + currentDirectionX < 0 ||
                    row + currentDirectionY >= n || row + currentDirectionY < 0 ||
                    matrix[col + currentDirectionX, row + currentDirectionY] != 0)
                { 
                    ChangeDirection(ref currentDirectionX, ref currentDirectionY);
                }
            }

                col += currentDirectionX;
                row += currentDirectionY;
                number++;
        }
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }

    private static int GetInputData()
    {
        n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 100)
        {
            throw new ArgumentOutOfRangeException("The correct input must be 0 < n <= 100");
        }

        return n;
    }

    private static bool CheckDirection(int[,] matrix, int x, int y)
    {
        int[] clonedDirectionX = (int[])dirX.Clone();
        int[] clonedDirectionY = (int[])dirY.Clone();
        

        for (int i = 0; i < 8; i++)
        {
            if (x + clonedDirectionX[i] >= matrix.GetLength(0) || x + clonedDirectionX[i] < 0)
            {
                clonedDirectionX[i] = 0;
            }

            if (y + clonedDirectionY[i] >= matrix.GetLength(0) || y + clonedDirectionY[i] < 0)
            {
                clonedDirectionY[i] = 0;
            }
        }

        for (int i = 0; i < 8; i++)
        {
            if (matrix[x + clonedDirectionX[i], y + clonedDirectionY[i]] == 0)
            {
                return true;
            }
        }

        return false;
    }   
}