using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> initValue = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            Stack<int> stack = new Stack<int>();
            int sum = 0;

            for (int i = 0; i < initValue.Count; i++)
            {
                stack.Push(initValue[i]);
            }

            string command;

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = command.Split(" ");
                string cmd = cmdArgs[0];
                if (cmd == "add")
                {
                    int N1 = int.Parse(cmdArgs[1]);
                    int N2 = int.Parse(cmdArgs[2]);

                    stack.Push((int)N1);
                    stack.Push((int)N2);
                }
                else if (cmd == "remove")
                { 
                    int numToRemove= int.Parse(cmdArgs[1]);
                    if (numToRemove > stack.Count)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < numToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }

                }
            }
            //Console.WriteLine(stack.Peek());
            while(stack.Count != 0)
            {
                sum = sum + stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
