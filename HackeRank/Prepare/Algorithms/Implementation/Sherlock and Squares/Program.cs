// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Enter the number of test cases:");
int q = int.Parse(Console.ReadLine());

for(int i = 0; i < q; i++)
{
    Console.WriteLine($"Test Case {i + 1}:");

    Console.Write("Enter the lower range boundary (a): ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Enter the upper range boundary (b): ");
    int b = int.Parse(Console.ReadLine());

    int result = CountSquareIntegers(a, b);
    Console.WriteLine($"Number of square integers in the range [{a}, {b}]: {result}");
    Console.WriteLine();
}

static int CountSquareIntegers(int a, int b)
{
    int count = 0;
    int current = 1;

    while(true)
    {
        int square = current * current;

        if(square > b)
        {
            break;
        }

        if(square >= a)
        {
            count++;
        }

        current++;
    }

    return count;
}