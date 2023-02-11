using System.Linq;
using System;

int[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string operation = string.Empty;

Func<string, int[], List<int>> operationForOutput = (operation, input) =>
{
    List<int> result = new List<int>();

    if (operation == "add")
    {
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = input[i] + 1;
            result.Add(input[i]);
        }
    }
    else if (operation == "multiply")
    {
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = input[i] * 2;
            result.Add(input[i]);
        }
    }
    else if (operation == "subtract")
    {
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = input[i] - 1;
            result.Add(input[i]);
        }
    }
    
    return result;
};

List<int> output = new List<int>();

while ((operation = Console.ReadLine()) != "end")
{
    if (operation != "print")
    {
        output = operationForOutput(operation, input);
    }
    else
    {
        Console.WriteLine(String.Join(" ", output));
    }
}

