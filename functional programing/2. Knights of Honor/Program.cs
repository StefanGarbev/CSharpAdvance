using System;

Action<string[]> print = (input) =>
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.WriteLine($"Sir {input[i]}");
    }
};

string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

print(input);

