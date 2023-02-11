using System;
using System.Linq;

int nameLenght = int.Parse(Console.ReadLine());

List<string> input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Func<List<string>,int, List<string>> operation = (input, nameLenght) =>
{
    List<string> result = new List<string>();

    foreach (string name in input)
    {
        if (name.Length <= nameLenght)
        { 
            result.Add(name);
        }
    }

    return result;
};

List<string> output = new List<string>();

output = operation(input, nameLenght);

Console.WriteLine(string.Join(Environment.NewLine, output));