using System;
using System.Collections.Generic;

namespace _3._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SortedSet<string> periodicTable = new SortedSet<string>(); 
            
            for (int i = 0; i < number; i++)
            { 
                string[] chemicalElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < chemicalElements.Length; j++)
                {
                    if (!periodicTable.Contains(chemicalElements[j]))
                    {
                        periodicTable.Add(chemicalElements[j]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
