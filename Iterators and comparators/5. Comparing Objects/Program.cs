namespace _5._Comparing_Objects;

public class StartUp
{
    public static void Main(string[] arg)
    {
        string input = string.Empty;
        List<Person> people = new List<Person>();

        while ((input = Console.ReadLine()) != "END")
        {
            string[] inputInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Person person = new Person(inputInfo[0], int.Parse(inputInfo[1]), inputInfo[2]);
            people.Add(person);
        }

        int positionToCompare = int.Parse(Console.ReadLine());
        positionToCompare -= 1;
        Person personToCompare = people[positionToCompare];

        int equalCount = 0;
        int diffCount = 0;

        foreach (var person in people)
        {
            if (person.CompareTo(personToCompare) == 0)
            {
                equalCount++;
            }
            else
            {
                diffCount++;
            }
        }

        if (equalCount == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{equalCount} {diffCount} {people.Count}");
        }
    }
}