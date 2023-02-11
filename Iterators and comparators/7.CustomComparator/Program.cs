namespace _7.CustomComparator;

public class StartUp
{
    public static void Main(string[] Arg)
    {
        Func<int, int, int> customComparator = (x, y) =>
        {
            if (x % 2 == 0 && y % 2 != 0)
            {
                return -1;
            }

            if (x % 2 != 0 && y % 2 == 0)
            {
                return 1;
            }

            return x.CompareTo(y);
        };
        int[] input = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Array.Sort(input, (x, y) => customComparator(x, y));

        Console.WriteLine(String.Join(" ", input));

    }        
}