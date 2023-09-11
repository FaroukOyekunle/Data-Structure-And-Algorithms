// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Welcome to the Cut the Sticks Program");
Console.Write("Enter the number of sticks (n): ");
        
if (!int.TryParse(Console.ReadLine(), out int n))
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
    return;
}

Console.WriteLine($"Enter {n} space-separated integers, each representing the length of a stick:");
string[] inputSticks = Console.ReadLine().Split(' ');

if (inputSticks.Length != n)
{
    Console.WriteLine($"Expected {n} integers. Please provide {n} space-separated integers.");
    return;
}

List<int> sticks = new List<int>();

foreach (string input in inputSticks)
{
    if (int.TryParse(input, out int stickLength))
    {
        sticks.Add(stickLength);
    }
            
    else
    {
        Console.WriteLine($"Invalid input: {input}. Stick length must be an integer.");
        return;
    }
}

List<int> result = CutTheSticks(sticks);

Console.WriteLine("Number of sticks before each cut operation is:");

foreach (int count in result)
{
    Console.WriteLine(count);
}

static List<int> CutTheSticks(List<int> arr)
{
    List<int> result = new List<int>();

    while (arr.Count > 0)
    {
        result.Add(arr.Count);

        int min = arr.Min();

        arr = arr.Select(x => x - min).Where(x => x > 0).ToList();
    }

    return result;
}