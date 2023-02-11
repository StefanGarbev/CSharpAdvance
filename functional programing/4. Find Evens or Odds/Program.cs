using System.Linq;

int[] bounds = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

//string typeOfNumber = Console.ReadLine();

int lowerBound = bounds[0];
int upperBound = bounds[1];

bool isEven = Console.ReadLine() == "even";

Func<int, int, List<int>> range = (x, y) =>
{
    List<int> result = new List<int>();

    for (int i = x; i <= y; i++)
    { 
        result.Add(i);
    }

    return result;
};

List<int> rangeOfNumber = range(lowerBound, upperBound);

Predicate<int> match;

if (isEven)
{
    match = number => number % 2 == 0;
}
else 
{
    match = number => number % 2 != 0;
}

List<int> result = new List<int>();

foreach(var number in rangeOfNumber)
{
    if (match (number))
    {
        result.Add(number);
    }
}

Console.WriteLine(string.Join(" ", result));