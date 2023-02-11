using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> openBrackets = new Stack<char>();
            Queue<char> closeBrackets = new Queue<char>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    openBrackets.Push(input[i]);
                }
                else if (input[i] == '}' || input[i] == ']' || input[i] == ')')
                {
                    closeBrackets.Enqueue(input[i]);
                }
            }

            while (openBrackets.Count != 0 || closeBrackets.Count != 0)
            {
                char open = openBrackets.Pop();
                char close = closeBrackets.Dequeue();

                if (open == '(' && close != ')' || open == '[' && close != ']' || open == '{' && close != '}')
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                    continue;
                }
            }

            if (!openBrackets.Any() && !closeBrackets.Any())
            {
                Console.WriteLine("YES");
            }
        }
    }
}
