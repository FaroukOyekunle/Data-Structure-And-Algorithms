// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to the Cavity Map Problem!");
Console.Write("Enter the number of rows and columns in the grid (n): ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the grid values row by row:");
List<string> grid = new List<string>();

for (int i = 0; i < n; i++)
{
    Console.Write($"Row {i + 1}: ");
    string row = Console.ReadLine()!;
    grid.Add(row);
}

List<string> result = CavityMap(grid);

Console.WriteLine("Modified Grid:");
foreach (string row in result)
{
    Console.WriteLine(row);
}

static List<string> CavityMap(List<string> grid)
{
    int n = grid.Count;
    char[][] map = new char[n][];

    for (int i = 0; i < n; i++)
    {
        map[i] = grid[i].ToCharArray();
    }

    for (int i = 1; i < n - 1; i++)
    {
        for (int j = 1; j < n - 1; j++)
        {
            int depth = map[i][j] - '0';

            if (depth > map[i - 1][j] - '0' && depth > map[i + 1][j] - '0' &&
            depth > map[i][j - 1] - '0' && depth > map[i][j + 1] - '0')
            {
                map[i][j] = 'X';
            }
        }
    }

    List<string> result = new List<string>();
    for (int i = 0; i < n; i++)
    {
        result.Add(new string(map[i]));
    }

    return result;
}  