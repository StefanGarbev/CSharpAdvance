using System;
using System.Linq;

namespace Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            int dimensionN = dimentions[0];
            int dimensionM = dimentions[1];

            char[,] matrix = new char[dimensionN, dimensionM];

            int currentIndex = 0;

            for (int row = 0; row < dimensionN; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < dimensionM; col++)
                    {
                        if (currentIndex == input.Length)
                        {
                            currentIndex = 0;
                        }

                        matrix[row, col] = input[currentIndex];

                        currentIndex++;
                    }
                }
                else
                {
                    for (int col = dimensionM - 1; col >= 0; col--)
                    {
                        if (currentIndex == input.Length)
                        {
                            currentIndex = 0;
                        }

                        matrix[row, col] = input[currentIndex];

                        currentIndex++;
                    }
                }
            }

            for (int row = 0; row < dimensionN; row++)
            {
                for (int col = 0; col < dimensionM; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();

            }
        }
    }
}
