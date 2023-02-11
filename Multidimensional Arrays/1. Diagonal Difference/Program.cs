using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] dimentions = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] colsValues = Console.ReadLine()
                    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < colsValues.Length; col++)
                { 
                    matrix[row, col] = colsValues[col];
                }
            }

            int sum = 0; 
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                { 
                    sum+=matrix[row, col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
