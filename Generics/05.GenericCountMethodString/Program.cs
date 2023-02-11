using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.GenericCountMethodString;

public class StartUp
{
    public static void Main(string[] args)
    {
        Box<string> box = new Box<string>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            box.Add(input);
        }

        string stringForCompare = Console.ReadLine();

        int value =  box.Count(stringForCompare);
        
        Console.WriteLine(value);
    }
}