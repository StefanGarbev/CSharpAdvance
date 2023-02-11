int sumOfCharecterBorder = int.Parse(Console.ReadLine());

List<string> names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();


Func<List<string>, int, Dictionary<string, int>> calculation = (names, sumOfCharecterBorder) =>
{
    Dictionary<string, int> nameOverBorder= new Dictionary<string, int>();

    foreach (string name in names)
    {
        int sum = 0;
        for (int i = 0; i < name.Length; i++)
        {
            sum += name[i];
        }
        if (sum >= sumOfCharecterBorder)
        { 
            nameOverBorder.Add(name, sum);
            return nameOverBorder;
        }
    }

    return nameOverBorder;
};

Action<Func<List<string>, int, Dictionary<string, int>>> Print = (calculation) =>
{
    Dictionary<string, int> keyValuePairs = calculation(names, sumOfCharecterBorder);

    foreach (var name in keyValuePairs)
    {
        Console.WriteLine(name.Key);
    }
};

Print(calculation);