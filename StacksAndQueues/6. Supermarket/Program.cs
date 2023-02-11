using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> customerName = new Queue<string>();
            string command = string.Empty;

            while (input != "End")
            {

                if (input != "Paid")
                {
                    customerName.Enqueue(input);
                }

                if (input == "Paid")
                {
                    command = input;
                }

                switch (command)
                {
                    case "Paid":
                        while (customerName.Count > 0)
                        {
                            Console.WriteLine($"{customerName.Dequeue()}");
                        }
                        break;
                }
                command = string.Empty;
                input = Console.ReadLine();
            }
            Console.WriteLine($"{customerName.Count} people remaining.");
        }
    }
}
