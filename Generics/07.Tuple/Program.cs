namespace _07.Tuple;

public class StartUp
{
    public static void Main(string[] ags)
    {
        string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] personBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        CustomTuple<string, string> person = new($"{personInfo[0]} {personInfo[1]}", personInfo[2]);

        CustomTuple<string, int> personAndBeer = new(personBeer[0], int.Parse(personBeer[1]));

        CustomTuple<int, double> numbers = new(int.Parse(nums[0]), double.Parse(nums[1]));

        Console.WriteLine(person.ToString());
        Console.WriteLine(personAndBeer.ToString());
        Console.WriteLine(numbers.ToString());

    }
}