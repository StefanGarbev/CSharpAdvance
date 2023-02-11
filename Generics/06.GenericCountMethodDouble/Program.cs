using System;
using System.Linq;
using System.Collections.Generic;
using _05.GenericCountMethodString;

namespace _06.GenericCountMethodDouble;

public class StartUp
{
    public static void Main(string[] args)
    {
        Box<double> box = new Box<double>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            double input = double.Parse(Console.ReadLine());
            box.Add(input);
        }

        double stringForCompare = double.Parse(Console.ReadLine());

        int value =  box.Count(stringForCompare);
        
        Console.WriteLine(value);
    }
}