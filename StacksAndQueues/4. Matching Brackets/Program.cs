using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            int stackIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }

                if (input[i] == ')')
                {
                    int openBracket = stack.Pop();

                    for (int j = openBracket; j <= i; j++)
                    {
                        
                        Console.Write(input[j]);
                    }

                    Console.WriteLine();
                }
            }

        }
    }
}
