using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.GenericSwapMethodInteger;

public class StartUp
{
    public static void Main(string[] args)
    {
        Box<int> box = new Box<int>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            box.Add(input);
        }

        int[] indexes = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int indexFirst = indexes[0];
        int indexLast = indexes[1];

        box.Swap(indexFirst, indexLast);

        Console.WriteLine(box.ToString());
    }
}