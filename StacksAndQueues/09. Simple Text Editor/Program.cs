using System;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;

            Stack<string> stack = new Stack<string>();

            int numberOfOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int command = int.Parse(cmdArgs[0]);

                if (command == 1)
                {
                    stack.Push(text);
                    text += cmdArgs[1];
                }
                else if (command == 2)
                {
                    int elementToRemove = int.Parse(cmdArgs[1]);
                    stack.Push(text);
                    text = text.Remove(text.Length - elementToRemove);
                }
                else if (command == 3)
                {
                    int index = int.Parse(cmdArgs[1]) - 1;
                    Console.WriteLine(text[index]);
                }
                else
                {
                    text = stack.Pop();
                }
            }
        }
    }
}
