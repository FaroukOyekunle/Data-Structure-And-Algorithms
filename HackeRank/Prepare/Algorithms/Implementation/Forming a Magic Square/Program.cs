// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

List<List<int>> s = new List<List<int>>();

Console.WriteLine("Enter the matrix s with 3 rows and 3 integers each:");

for(int i = 0; i < 3; i++)
{
    string rowInput = Console.ReadLine();
    List<int> row = new List<int>();

        foreach(char numChar in rowInput)
        {
            if(Char.IsDigit(numChar))
            {
                int numValue = numChar - '0';
                row.Add(numValue);
            }
        }

        s.Add(row);
}

int cost = FormingMagicSquare(s);
Console.WriteLine("The minimal total cost of converting the input square to a magic square is: " + cost);

static int FormingMagicSquare(List<List<int>> s)
{
    int[][] possibleMagicSquares = new int[][] 
    {
        new int[] {8, 1, 6, 3, 5, 7, 4, 9, 2},
        new int[] {6, 1, 8, 7, 5, 3, 2, 9, 4},
        new int[] {4, 9, 2, 3, 5, 7, 8, 1, 6},
        new int[] {2, 9, 4, 7, 5, 3, 6, 1, 8},
        new int[] {8, 3, 4, 1, 5, 9, 6, 7, 2},
        new int[] {4, 3, 8, 9, 5, 1, 2, 7, 6},
        new int[] {6, 7, 2, 1, 5, 9, 8, 3, 4},
        new int[] {2, 7, 6, 9, 5, 1, 4, 3, 8}
    };
    
    int minCost = int.MaxValue;
    
    foreach(var magicSquare in possibleMagicSquares) 
    {
        int cost = 0;
        for(int i = 0; i < 9; i++) 
        {
            cost += Math.Abs(s[i / 3][i % 3] - magicSquare[i]);
        }
        minCost = Math.Min(minCost, cost);
    }
    
    return minCost;
}