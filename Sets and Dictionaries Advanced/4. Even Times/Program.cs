using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbersCounts = new Dictionary<int, int>();
     

            for (int i = 0; i < number; i++)
            { 
                int input = int.Parse(Console.ReadLine());
                
                if (!numbersCounts.ContainsKey(input))
                {
                    numbersCounts.Add(input, 0);
                }

                numbersCounts[input]++;

            }

            // Console.WriteLine(numbersCounts.Single(n => n.Value % 2 == 0).Key);

            foreach (var input in numbersCounts)
            {
                if (input.Value % 2 == 0)
                {
                    Console.WriteLine(input.Key);
                }
            }
        }
    }
}
