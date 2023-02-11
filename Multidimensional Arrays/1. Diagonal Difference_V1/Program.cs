using System;
using System.Linq;

namespace _1._Diagonal_Difference_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++)
            {
                int[] colValues = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < colValues.Length; col++)
                {
                    matrix[row,col] = colValues[col];
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                primaryDiagonal+= matrix[i,i];   
            }
            int k = 0;
            for (int j = n - 1 - k; j >= 0; j--)
            {
                secondaryDiagonal += matrix[k, j];
                k++;
            }
            int sum = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(sum);
        }
    }
}
