using System;
using System.Collections.Generic;

namespace _5._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
                
            SortedDictionary <char, int> charsAlphabeticaly = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!charsAlphabeticaly.ContainsKey(input[i]))
                { 
                    charsAlphabeticaly.Add(input[i], 0);
                }
                charsAlphabeticaly[input[i]]++;
            }

            foreach (var (key, value) in charsAlphabeticaly)
            {
                Console.WriteLine($"{key}: {value} time/s");
            }
        }
    }
}
