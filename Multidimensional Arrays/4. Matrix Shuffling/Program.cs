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
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandFirstElement = commandArgs[0];
                if (commandFirstElement != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    int row1 = int.Parse(commandArgs[1]);
                    int col1 = int.Parse(commandArgs[2]);
                    int row2 = int.Parse(commandArgs[3]);
                    int col2 = int.Parse(commandArgs[4]);
                    int commandArgsCount = commandArgs.Count();


                    if (row1 < 0 || row1 > row || col1 < 0 || col1 > col
                        || row2 < 0 || row2 > row || col2 < 0 || col2 > col || commandArgsCount < 5 || commandArgsCount > 5)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    else
                    {
                        string swapIndex1 = matrix[row1, col1];
                        string swapIndex2 = matrix[row2, col2];

                        matrix[row2, col2] = swapIndex1;
                        matrix[row1, col1] = swapIndex2;

                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }

                            Console.WriteLine();

                        }
                    }
                }
            }
        }
    }
}
