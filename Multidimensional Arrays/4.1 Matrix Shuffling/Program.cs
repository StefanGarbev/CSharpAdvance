using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int row = int.Parse(dimentions[0]);
            int col = int.Parse(dimentions[1]);

            string[,] matrix = new string[row, col];

            for (int i = 0; i < row; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < col; j++)
                {

                    matrix[i, j] = input[j];
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandArgs = command.Split(new string[] {" ",""}, StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "swap" && commandArgs.Length == 5
                    && int.Parse(commandArgs[1]) >= 0 && int.Parse(commandArgs[1]) < row
                    && int.Parse(commandArgs[2]) >= 0 && int.Parse(commandArgs[2]) < col
                    && int.Parse(commandArgs[3]) >= 0 && int.Parse(commandArgs[3]) < row
                    && int.Parse(commandArgs[4]) >= 0 && int.Parse(commandArgs[4]) < col)
                {

                    string swapIndex1 = matrix[int.Parse(commandArgs[1]), int.Parse(commandArgs[2])];
                    string swapIndex2 = matrix[int.Parse(commandArgs[3]), int.Parse(commandArgs[4])];
                    //
                    matrix[int.Parse(commandArgs[3]), int.Parse(commandArgs[4])] = swapIndex1;
                    matrix[int.Parse(commandArgs[1]), int.Parse(commandArgs[2])] = swapIndex2;

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Console.Write($"{matrix[i, j]} ");
                        }

                        Console.WriteLine();

                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
