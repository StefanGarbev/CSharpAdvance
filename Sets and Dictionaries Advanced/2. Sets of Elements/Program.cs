using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] setsLenght = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSetInputLenght = setsLenght[0];
            int secondSetIntputLenght = setsLenght[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetInputLenght; i++)
            { 
                int input = int.Parse(Console.ReadLine());

                if (!firstSet.Contains(input))
                { 
                    firstSet.Add(input);
                }
            }

            for (int i = 0; i < secondSetIntputLenght; i++)
            { 
                int input = int.Parse(Console.ReadLine());

                if (!secondSet.Contains(input))
                { 
                    secondSet.Add(input);
                }
            }

            firstSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ", firstSet));
        }
    }
}
