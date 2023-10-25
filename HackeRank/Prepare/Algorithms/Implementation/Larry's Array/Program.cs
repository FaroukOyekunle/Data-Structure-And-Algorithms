// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to Larry's Array Checker!");
Console.Write("Enter the number of test cases: ");
int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    Console.Write("Enter the length of array A: ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Enter space-separated integers for array A: ");
    string[] input = Console.ReadLine().Split(' ');
    List<int> A = new List<int>();

    for (int j = 0; j < n; j++)
    {
        A.Add(int.Parse(input[j]));
    }

    string result = LarrysArray(A);
    Console.WriteLine("Test Case " + (i + 1) + ": " + result);
}
static string LarrysArray(List<int> A)
{
    int inversionCount = 0;

    for (int i = 0; i < A.Count; i++)
    {
        for (int j = i + 1; j < A.Count; j++)
        {
            if (A[i] > A[j])
            {
                inversionCount++;
            }
        }
    }

    return inversionCount % 2 == 0 ? "YES" : "NO";
}    