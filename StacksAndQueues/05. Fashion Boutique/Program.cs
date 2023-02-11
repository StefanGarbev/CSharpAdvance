using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> boxClothes = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int rackCapacity = int.Parse(Console.ReadLine());
            
            int currentRack = rackCapacity;
            int rackQuantity = 1;

            while (boxClothes.Any())
            { 
                currentRack-=boxClothes.Peek();

                if (currentRack < 0)
                {
                    currentRack = rackCapacity;
                    rackQuantity++;

                    continue;
                }

                boxClothes.Pop();
            }

            Console.WriteLine(rackQuantity);
        }
    }
}
