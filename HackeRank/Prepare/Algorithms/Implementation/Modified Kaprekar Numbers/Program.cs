// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Welcome to the Modified Kaprekar Number Finder!");
Console.Write("Enter the lower limit (p): ");
int p = int.Parse(Console.ReadLine()!);

Console.Write("Enter the upper limit (q): ");
int q = int.Parse(Console.ReadLine()!);

Console.WriteLine("Modified Kaprekar Numbers in the given range:");
KaprekarNumbers(p, q);

static void KaprekarNumbers(int p, int q)
{
    bool found = false;
    for (int number = p; number <= q; number++)
    {
        long square = (long)number * number;
        string squareNumber = square.ToString();
        int d = number.ToString().Length;

        int right = int.Parse(squareNumber.Substring(squareNumber.Length - d));
        int left = (squareNumber.Length > d) ? int.Parse(squareNumber.Substring(0, squareNumber.Length - d)) : 0;

        if (left + right == number)
        {
            Console.Write(number + " ");
            found = true;
        }
    }

    if (!found)
        Console.WriteLine("INVALID RANGE");
    else
        Console.WriteLine();
}    