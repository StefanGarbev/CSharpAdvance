using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            int[][] jaggedAray = new int[numberOfRows][];

            for (int row = 0; row < numberOfRows; row++)
            {
                int[] cols = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedAray[row] = cols;
            }

            for (int row = 0; row < numberOfRows - 1; row++)
            {
                if (jaggedAray[row].Length == jaggedAray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedAray[row].Length; col++)
                    {
                        jaggedAray[row][col] *= 2;
                        jaggedAray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedAray[row].Length; col++)
                    {
                        jaggedAray[row][col] /= 2;
                    }

                    for (int col = 0; col < jaggedAray[row + 1].Length; col++)
                    {
                        jaggedAray[row + 1][col] /= 2;
                    }
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];

                if (command == "Add")
                {
                    int row = int.Parse(commandArgs[1]);
                    int column = int.Parse(commandArgs[2]);
                    int value = int.Parse(commandArgs[3]);

                    if (row >= 0 && row < jaggedAray.Length && column >= 0 && column < jaggedAray[row].Length)
                    {
                        jaggedAray[row][column] += value;
                    }

                }
                else if (command == "Subtract")
                {
                    int row = int.Parse(commandArgs[1]);
                    int column = int.Parse(commandArgs[2]);
                    int value = int.Parse(commandArgs[3]);

                    if (row >= 0 && row < jaggedAray.Length && column >= 0 && column < jaggedAray[row].Length)
                    {
                        jaggedAray[row][column] -= value;
                    }
                }
            }

            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < jaggedAray[row].Length; col++)
                {
                    Console.Write($"{jaggedAray[row][col]} ");
                }

                Console.WriteLine();

            }
        }
    }
}
