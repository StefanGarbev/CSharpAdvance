using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis_Var2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> openBrackets = new Stack<char>();
            string input = Console.ReadLine();

            foreach (char parenthesis in input)
            {
                switch (parenthesis)
                { 
                    case '(':
                    case '[':
                    case '{':
                        openBrackets.Push(parenthesis);
                        break;

                    case ')':
                        if (openBrackets.Count == 0 || openBrackets.Pop() != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ']':
                        if (openBrackets.Count == 0 || openBrackets.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case '}':
                        if (openBrackets.Count == 0 || openBrackets.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;

                }
            }
            if (openBrackets.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
