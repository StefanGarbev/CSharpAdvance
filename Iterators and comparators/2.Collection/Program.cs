namespace _2.Collection;

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
            else if (command == "Print")
            {
                try
                {
                    listyIterator.Print();
                }
                catch(Exception message)
                {
                    Console.WriteLine(message.Message);
                }
            }
            else
            {
                Console.WriteLine(String.Join(" ", listyIterator));
            }
        }
    }
}
