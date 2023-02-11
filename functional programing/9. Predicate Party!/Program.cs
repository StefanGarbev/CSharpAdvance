List<string> peopleWhoWillCome = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string criteria = string.Empty;

while ((criteria = Console.ReadLine()) != "Party!")
{
    string[] commandArgs = criteria
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = commandArgs[0];
    string filter = commandArgs[1];
    string value = commandArgs[2];

    if (command == "Remove")
    {
        peopleWhoWillCome.RemoveAll(GetPredicate(filter, value));
    }
    else if (command == "Double")
    {
        List<string> personToDouble = peopleWhoWillCome.FindAll(GetPredicate(filter, value));

        foreach (string person in personToDouble)
        {
            int index = peopleWhoWillCome.FindIndex(p => p == person);

            peopleWhoWillCome.Insert(index, person);
        }
        
    }


}

if (peopleWhoWillCome.Any())
{
    Console.WriteLine($"{string.Join(", ", peopleWhoWillCome)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

static Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "StartsWith":
            return p => p.StartsWith(value);
        case "EndsWith":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        default:
            return default;
    }
}
