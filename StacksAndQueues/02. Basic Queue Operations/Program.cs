using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbersToPushed = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberToPushInQueue = input[0];
            int numberToPopFromQueue = input[1];
            int searchedElementInQueue = input[2];

            for (int i = 0; i < numberToPushInQueue; i++)
            {
                numbers.Enqueue(numbersToPushed[i]);
            }

            for (int i = 0; i < numberToPopFromQueue; i++)
            {
                if (numbers.Count > 0)
                {
                    numbers.Dequeue();
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine($"{0}");
            }
            else if (numbers.Count > 0)
            {
                if (numbers.Contains(searchedElementInQueue))
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
