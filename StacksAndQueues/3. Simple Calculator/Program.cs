using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
               
            Stack<int> stack = new Stack<int>();
            Stack<string> operation = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "+" || input[i] == "-")
                {
                    operation.Push(input[i]);
                }
                else
                {
                    stack.Push(int.Parse(input[i]));
                }
            }
            int number = 0;
            string symbol = string.Empty; 
            int sum = 0;

            while (stack.Count != 0)
            { 
                number = stack.Pop();
                if (operation.Count == 0)
                {
                    sum = sum + number;
                }
                else
                {
                    symbol = operation.Pop();


                    if (symbol == "+")
                    {
                        sum = sum + number;
                    }
                    else if (symbol == "-")
                    {
                        sum = sum - number;
                    }
                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}
