using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbersToPushed = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberToPushInStack = input[0];
            int numberToPopFromStack = input[1];
            int searchedElementInStack = input[2];

            for (int i = 0; i < numberToPushInStack; i++)
            {
                numbers.Push(numbersToPushed[i]);
            }

            for (int i = 0; i < numberToPopFromStack; i++)
            {
                if (numbers.Count > 0)
                {
                    numbers.Pop();
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine($"{0}");
            }
            else if (numbers.Count > 0)
            {
                if (numbers.Contains(searchedElementInStack))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine($"{numbers.Min()}");
                }
            }
        }
    }
}
