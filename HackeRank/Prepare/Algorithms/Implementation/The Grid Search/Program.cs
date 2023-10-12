// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to the Grid Search Problem!");
Console.Write("Enter the number of test cases (T): ");
int T = int.Parse(Console.ReadLine());

for (int t = 0; t < T; t++)
{
    Console.WriteLine($"Test Case {t + 1}:");
    Console.Write("Enter the number of rows in the search grid G and the length of each row (R C): ");
    string[] gridDimensions = Console.ReadLine().Split(' ');
    int R = int.Parse(gridDimensions[0]);
    int C = int.Parse(gridDimensions[1]);

    List<string> G = new List<string>();
    for (int i = 0; i < R; i++)
    {
        Console.Write($"Enter row {i + 1} of the grid: ");
        G.Add(Console.ReadLine());
    }

    Console.Write("Enter the number of rows in the pattern grid P and the length of each pattern row (r c): ");
    string[] patternDimensions = Console.ReadLine().Split(' ');
    int r = int.Parse(patternDimensions[0]);
    int c = int.Parse(patternDimensions[1]);

    List<string> P = new List<string>();
    for (int i = 0; i < r; i++)
    {
        Console.Write($"Enter row {i + 1} of the pattern: ");
        P.Add(Console.ReadLine());
    }

    string result = GridSearch(G, P);

    Console.WriteLine("Pattern Found: " + result);
}

static string GridSearch(List<string> G, List<string> P)
{
    int R = G.Count;
    int r = P.Count;
    int C = G[0].Length;
    int c = P[0].Length;

    for (int i = 0; i <= R - r; i++)
    {
        for (int j = 0; j <= C - c; j++)
        {
            if (G[i].Substring(j, c) == P[0])
            {
                bool found = true;
                for (int k = 1; k < r; k++)
                {
                    if (G[i + k].Substring(j, c) != P[k])
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                    return "YES";
                }
            }
        }

    return "NO";
}    