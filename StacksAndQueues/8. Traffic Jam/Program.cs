using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarCanPass = int.Parse(Console.ReadLine());
            string input = string.Empty;
            Queue<string> cars = new Queue<string>();
            int counter = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    for (int i = 0; i < numberOfCarCanPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
