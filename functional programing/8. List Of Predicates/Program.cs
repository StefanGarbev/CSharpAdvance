int endOfRange = int.Parse(Console.ReadLine());
int[] deviders = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

List<int> listOfNumRange = new List<int>();
HashSet<int> devider = new HashSet<int>();

foreach (var dev in deviders)
{
    if (!devider.Contains(dev))
    {
        devider.Add(dev);
    }
}

Func<int, List<int>> listOfValues = (endOfRange) =>
{
    List<int> values = new List<int>();

    for (int i = 1; i <= endOfRange; i++)
    {
        values.Add(i);
    }
    return values;
};

listOfNumRange = listOfValues(endOfRange);
List<Predicate<int>> Predicates = new List<Predicate<int>>();
foreach (var div in devider)
{
    Predicates.Add(p => p % div == 0);
}

foreach (var num in listOfNumRange)
{
    bool isDevisible = true;
    foreach (var match in Predicates)
    {
        if (!match(num))
        { 
            isDevisible = false;
            break;
        }
    }
    if (isDevisible)
    {
        Console.Write($"{num} ");
    }

}

