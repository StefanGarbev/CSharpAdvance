﻿int[] input = Console.ReadLine()
    .Split(", ",  StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Where(x=> x % 2==0)
    .OrderBy(x=>x)
    .ToArray();


Console.WriteLine(String.Join(", ", input));