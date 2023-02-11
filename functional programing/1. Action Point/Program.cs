using System;

Action<string[]> print = (input) =>
{
    Console.WriteLine(string.Join(Environment.NewLine, input));
};

string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

print(input);
