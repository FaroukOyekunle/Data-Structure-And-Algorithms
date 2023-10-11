// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to the Stone Problem!");
Console.Write("Enter the number of test cases (T): ");
int T = int.Parse(Console.ReadLine()!);

for (int i = 0; i < T; i++)
{
    Console.WriteLine($"Test Case {i + 1}:");
    Console.Write("Enter the number of non-zero stones found (n): ");
    int n = int.Parse(Console.ReadLine()!);

    Console.Write("Enter one possible difference (a): ");
    int a = int.Parse(Console.ReadLine()!);

    Console.Write("Enter the other possible difference (b): ");
    int b = int.Parse(Console.ReadLine()!);

    List<int> possibleValues = Stones(n, a, b);

    Console.WriteLine("Possible Values of the Last Stone (sorted ascending):");
    
    foreach (int value in possibleValues)
    {
        Console.Write(value + " ");
    }

    Console.WriteLine(); 
}

static List<int> Stones(int n, int a, int b)
{
    List<int> result = new List<int>();

    for (int i = 0; i < n; i++)
    {
        int stone = (n - 1 - i) * Math.Min(a, b) + i * Math.Max(a, b);
        if (!result.Contains(stone))
        {
            result.Add(stone);
        }
    }

    result.Sort();
    return result;
}       