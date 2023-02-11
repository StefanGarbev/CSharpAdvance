using System;
using System.Collections.Generic;

namespace _6._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<string , Dictionary<string , int>> cloths = new Dictionary<string , Dictionary<string , int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] colorAndCloths  = Console.ReadLine()
                    .Split(new string[] {" -> ", ","},StringSplitOptions.RemoveEmptyEntries); 

                string color = colorAndCloths[0];

                if (!cloths.ContainsKey(color))
                { 
                    cloths.Add(color, new Dictionary<string , int>());
                }

               
                for (int j = 1; j < colorAndCloths.Length; j++)
                {
                    string currentCloth = colorAndCloths[j];

                    if (!cloths[color].ContainsKey(currentCloth))
                    { 
                        cloths[color].Add(currentCloth, 0);
                    }

                    cloths[color][currentCloth]++;

                }
            }
            string[] founingCloths = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string foundingColor = founingCloths[0];
            string foundingCloths = founingCloths[1];

            foreach (var clothesColor in cloths)
            {
                Console.WriteLine($"{clothesColor.Key} clothes:");

                foreach (var printClothsItem in clothesColor.Value)
                {
                    string printItem = $"* {printClothsItem.Key} - {printClothsItem.Value}";

                    if (clothesColor.Key == foundingColor && printClothsItem.Key == foundingCloths)
                    {
                        printItem += " (found!)";
                    }

                    Console.WriteLine(printItem);
                }
            }
        }
    }
}
