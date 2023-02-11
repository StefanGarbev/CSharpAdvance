using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> result = new List<int>();
            Queue<int> queueEven = new Queue<int>(); 

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    queueEven.Enqueue(input[i]);
                }
            }
            while (queueEven.Count > 0)
            {
                result.Add(queueEven.Dequeue());
            }

            Console.Write(string.Join(", ", result));
        }
    }
}
