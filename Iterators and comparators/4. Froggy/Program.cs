using _4._Froggy;
using System;
using System.Linq;


int[] inputStones = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

FroggyPath frog = new FroggyPath(inputStones);

Console.WriteLine(String.Join(", ", frog));