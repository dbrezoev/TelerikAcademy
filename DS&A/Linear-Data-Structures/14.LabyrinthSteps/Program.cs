using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int n = 6;

            string[,] matrix = 
            {                
                {"0", "0", "0", "x", "0", "x"}, 
                {"0", "x", "0", "x", "0", "x"}, 
                {"0", "*", "x", "0", "x", "0"}, 
                {"0", "x", "0", "0", "0", "0"}, 
                {"0", "0", "0", "x", "x", "0"}, 
                {"0", "0", "0", "x", "0", "x"}, 
            };          

            int startRowIndex;
            int startColIndex;

            FindStartPosition(matrix, out startRowIndex, out startColIndex);

            DFS(startRowIndex, startColIndex, matrix);

            Console.WriteLine();
            PrintMatrix(matrix);
        }

        public static void DFS(int startRow, int startCol, string[,] matrix, int steps = 0)
        {
            if (startRow >= matrix.GetLength(0) || startRow < 0 ||
                startCol >= matrix.GetLength(1) || startCol < 0 ||
                matrix[startRow, startCol] == "x")
            {
                return;
            }

            if (matrix[startRow, startCol] == "0" || matrix[startRow, startCol] == "*" || int.Parse(matrix[startRow, startCol]) > steps)
            {
                if (matrix[startRow, startCol] != "*")
                {
                    matrix[startRow, startCol] = steps.ToString();
                }

                DFS(startRow + 1, startCol, matrix, steps + 1);
                DFS(startRow - 1, startCol, matrix, steps + 1);
                DFS(startRow, startCol + 1, matrix, steps + 1);
                DFS(startRow, startCol - 1, matrix, steps + 1);
            }
        }

        private static void FindStartPosition(string[,] matrix, out int startRowIndex, out int startColIndex)
        {
            startRowIndex = 0;
            startColIndex = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var currentCell = matrix[row, col];

                    if (currentCell == "*")
                    {
                        startRowIndex = row;
                        startColIndex = col;
                    }
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
