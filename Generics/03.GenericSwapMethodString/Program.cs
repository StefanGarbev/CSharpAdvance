using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.GenericSwapMethodString;

public class StartUp
{
    public static void Main(string[] args)
    {
        Box<string> box = new Box<string>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
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