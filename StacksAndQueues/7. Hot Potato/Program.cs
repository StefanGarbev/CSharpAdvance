using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] childName = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int moves = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>();
            int tosses = 1;

            for (int i = 0; i < childName.Length; i++)
            { 
                kids.Enqueue(childName[i]);
            }

            while (kids.Count != 1)
            { 
                string kid = kids.Dequeue();

                if (tosses < moves)
                {
                    tosses++;
                    kids.Enqueue(kid);
                }
                else
                {
                    Console.WriteLine($"Removed {kid}");
                    tosses = 1;
                }
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
