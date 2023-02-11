using System;
using _08.Threeuple;

namespace _08.Threeuple;

public class StartUp
{
    public static void Main(string[] ags)
    {
        string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] personBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        CustomTuple<string, string, string> person = new($"{personInfo[0]} {personInfo[1]}", personInfo[2], 
            string.Join(" ", personInfo[3..]));

        CustomTuple<string, int, bool> drinks = new(personBeer[0], int.Parse(personBeer[1]), personBeer[2] == "drunk");

        CustomTuple<string, double, string> numbers = new(nums[0], double.Parse(nums[1]), nums[2]);

        Console.WriteLine(person);
        Console.WriteLine(drinks);
        Console.WriteLine(numbers);

    }
}