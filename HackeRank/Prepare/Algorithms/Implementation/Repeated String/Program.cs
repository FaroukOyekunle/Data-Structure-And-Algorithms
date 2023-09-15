// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Welcome to the Repeated String Counter");
        
Console.Write("Enter a string of lowercase English letters: ");
string s = Console.ReadLine();

Console.Write("Enter the number of characters to consider (n): ");
long n = long.Parse(Console.ReadLine());

long result = RepeatedString(s, n);
Console.WriteLine($"The frequency of 'a' in the first {n} characters of the infinite string is: {result}");


static long RepeatedString(string s, long n)
{
    long countInS = 0;
    foreach (char c in s)
    {
        if (c == 'a')
        {
            countInS++;
        }
    }

    long fullRepeats = n / s.Length;

    long totalCount = countInS * fullRepeats;

    long partialLength = n % s.Length;

    for (int i = 0; i < partialLength; i++)
    {
        if (s[i] == 'a')
        {
            totalCount++;
        }
    }

    return totalCount;
}