using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfQueryOperation = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(); 

            for (int i = 0; i < numberOfQueryOperation; i++)
            {
                int[] input = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

                int command = input[0];

                if (command == 1)
                {
                    int numberForAdd = input[1];
                    stack.Push(numberForAdd);
                }
                else if (command == 2)
                {
                    stack.Pop();
                }
                else if (command == 3)
                {
                    if (stack.Count > 0)
                    {
                        int max = 0;
                        max = stack.Max();
                        Console.WriteLine(max);
                    }
                }
                else if (command == 4)
                {
                    if (stack.Count > 0)
                    { 
                        int min = 0;
                        min = stack.Min();
                        Console.WriteLine(min);
                    }
                }
               
            }
            if (stack.Count > 0)
            {
                Console.WriteLine(string.Join(", ", stack));
            }
        }
    }
}
