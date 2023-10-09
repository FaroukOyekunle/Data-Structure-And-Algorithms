// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to the Fair Rations Problem!");
Console.Write("Enter the number of people in the bread line: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write("Enter the initial number of loaves for each person separated by spaces: ");
string input = Console.ReadLine()!;
string[] inputArray = input.Split(' ');
List<int> loavesList = new List<int>();

for (int i = 0; i < N; i++)
{
    int loaf = int.Parse(inputArray[i]);
    loavesList.Add(loaf);
}

string result = FairRations(loavesList);
Console.WriteLine($"Minimum loaves required is: {result}");

static string FairRations(List<int> B)
{
    int n = B.Count;
    int loavesGiven = 0;

    for (int i = 0; i < n - 1; i++)
    {
        if (B[i] % 2 == 1)
        {
            B[i]++;
            B[i + 1]++;
            loavesGiven += 2;
        }
    }

    if (B[n - 1] % 2 == 1)
    {
        return "NO";
    }

    return loavesGiven.ToString();
}