namespace _5.DateModifier;

public class StartUp
{
    public static void Main(string[] args)
    {
        string start = Console.ReadLine();
        string end = Console.ReadLine();

        int diffrence =DateModifier.GetDiffrenceInDays(start, end);

        Console.WriteLine(diffrence);
    }
}