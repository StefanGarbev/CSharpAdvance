using System.Linq;
using System;
using System.Collections.Generic;

List<string> peopleWhoWillCome = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string criteria = string.Empty;
Dictionary<string, Predicate<string>> filters = new();


while ((criteria = Console.ReadLine()) != "Print")
{
    string[] commandArgs = criteria
        .Split(";", StringSplitOptions.RemoveEmptyEntries);

    string command = commandArgs[0];
    string filter = commandArgs[1];
    string value = commandArgs[2];

    if (command == "Add filter")
    {
        filters.Add(filter + value, GetPredicate(filter, value));
    }
    else if (command == "Remove filter")
    {
        filters.Remove(filter + value);
    }
}

foreach (var filter in filters)
{
    peopleWhoWillCome.RemoveAll(filter.Value);
}

Console.WriteLine($"{string.Join(", ", peopleWhoWillCome)}");


static Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "StartsWith":
            return p => p.StartsWith(value);
        case "EndsWith":
            return p => p.EndsWith(value);
        case "Contains":
            return p => p.Contains(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        default:
            return default;
    }
}
