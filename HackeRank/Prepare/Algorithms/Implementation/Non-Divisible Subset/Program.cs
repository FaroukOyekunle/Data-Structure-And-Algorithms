// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to the Non-Divisible Subset Program");

Console.Write("Enter the number of values in S and the divisor (n k): ");
        
string[] input = Console.ReadLine().Split(' ');

if (input.Length != 2 || !int.TryParse(input[0], out int n) || !int.TryParse(input[1], out int k))
{
    Console.WriteLine("Invalid input format. Please enter two space-separated integers.");
    return;
}

Console.WriteLine($"Enter {n} space-separated unique integers, the values of set S:");

string[] inputValues = Console.ReadLine().Split(' ');

if (inputValues.Length != n)
{
    Console.WriteLine($"Expected {n} integers. Please provide {n} space-separated integers.");
    return;
}

List<int> s = new List<int>();

foreach (string inputValue in inputValues)
{
    if (int.TryParse(inputValue, out int value))
    {
        s.Add(value);
    }
            
    else
    {
        Console.WriteLine($"Invalid input: {inputValue}. Please enter valid integers.");
        return;
    }
}

int result = NonDivisibleSubset(k, s);
Console.WriteLine($"The size of the maximal subset of S where the sum of any 2 numbers is not evenly divisible by {k} is: {result}");


static int NonDivisibleSubset(int k, List<int> s)
{
    int[] remainderCount = new int[k];

    foreach (int num in s)
    {
        int remainder = num % k;
        remainderCount[remainder]++;
    }

    int result = (remainderCount[0] > 0) ? 1 : 0;

    for (int i = 1; i <= k / 2; i++)
    {
        if (i != k - i)
        {
            result += Math.Max(remainderCount[i], remainderCount[k - i]);
        }
            
        else
        {
            result++;
        }
    }

    return result;
}