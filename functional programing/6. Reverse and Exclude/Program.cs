using System;
using System.Linq;

int[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int devisibleNumber = int.Parse(Console.ReadLine());
List<int> output = new List<int>();

Func<int[], int ,List<int>> operation = (input, devisibleNumber) =>
{
    List<int> result = new List<int>();

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] % devisibleNumber != 0)
        { 
            result.Add(input[i]);
        }
    }
    return result;
};

output = operation(input, devisibleNumber);

Func<List<int>, List<int>> reverse = output =>
{
    List<int> result = new();

    for (int i = output.Count - 1; i >= 0; i--)
    {
        result.Add(output[i]);
    }

    return result;
};

output = reverse(output);

Console.WriteLine(string.Join(" ",output));