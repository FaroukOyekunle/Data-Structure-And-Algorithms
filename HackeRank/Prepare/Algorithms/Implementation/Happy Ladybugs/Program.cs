// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to the Happy Ladybugs Game!");
Console.Write("Enter the number of games: ");
int g = int.Parse(Console.ReadLine());

for (int i = 0; i < g; i++)
{
    Console.Write("Enter the length of the board (n): ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Enter the configuration of ladybugs: ");
    string ladybugs = Console.ReadLine();

    string result = HappyLadybugs(ladybugs);
    Console.WriteLine("Game " + (i + 1) + ": " + result);
}

static string HappyLadybugs(string b)
{
    int n = b.Length;

    bool hasEmptyCells = b.Contains('_');

    if (!hasEmptyCells)
    {
        for (int i = 0; i < n;)
        {
            char current = b[i];
            int count = 0;
            while (i < n && b[i] == current)
            {
                i++;
                count++;
            }
            
            if (count == 1)
                return "NO";
            }
        return "YES";
        }

    Dictionary<char, int> ladybugCounts = new Dictionary<char, int>();
    foreach (char bug in b)
    {
        if (bug != '_')
        {
            if (!ladybugCounts.ContainsKey(bug))
                ladybugCounts[bug] = 0;
                ladybugCounts[bug]++;
            }
        }

    foreach (var count in ladybugCounts.Values)
    {
        if (count == 1)
            return "NO";
        }

    return "YES";
}    