// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

Console.WriteLine("Enter the number of elements in the sequence:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Enter space-separated integers for the sequence:");
List<int> permutation = new List<int>();

string[] input = Console.ReadLine().Split(' ');
for(int i = 0; i < n; i++)
{
    permutation.Add(int.Parse(input[i]));
}

List<int> yValues = FindYValues(permutation);

Console.WriteLine("The values of y for all x in the sequence:");
foreach(int y in yValues)
{
    Console.WriteLine(y);
}

static List<int> FindYValues(List<int> permutation)
{
    int n = permutation.Count;
    List<int> result = new List<int>();

    for(int x = 1; x <= n; x++)
    {
        int xIndex = permutation.IndexOf(x) + 1;
        int y = permutation.IndexOf(xIndex) + 1;
        result.Add(y);
    }

    return result;
}