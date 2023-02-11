namespace _1.ListyIterator;

public class StartUp
{
    public static void Main(string[] args)
    {
        List<string> list = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Skip(1)
            .ToList();

        ListyIterator<string> listyIterator = new ListyIterator<string>(list);

        string command = string.Empty;

        while ((command = Console.ReadLine()) != "END")
        {
            if (command == "Move")
            {
                Console.WriteLine(listyIterator.Move());
            }
            else if (command == "HasNext")
            {
                Console.WriteLine(listyIterator.HasNext());
            }
            else
            {
                listyIterator.Print();
            }
        }

        Console.WriteLine();

    }
}
