using System.Linq;
using System;

HashSet<int> numbers = new HashSet<int>();
int[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Func<HashSet<int>, int> smallestNum = (numbers) =>
{
    int smallest = int.MaxValue;

    foreach (int num in numbers)
    {
        if (smallest > num)
        { 
            smallest = num;
        }
    }
    return smallest;
};

for (int i = 0; i < input.Length; i++)
{
    if (!numbers.Contains(input[i]))
    { 
        numbers.Add(input[i]);
    }
}

int smallest = smallestNum(numbers);
Console.WriteLine(smallest);