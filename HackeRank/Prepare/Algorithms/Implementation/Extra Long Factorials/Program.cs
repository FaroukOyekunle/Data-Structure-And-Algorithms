// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;

Console.WriteLine("Enter an integer to calculate its factorial:");
int userInput = int.Parse(Console.ReadLine());

ExtraLongFactorials(userInput);

static void ExtraLongFactorials(int number)
{
    BigInteger result = 1;

    for(int i = 2; i <= number; i++)
    {
        result *= i;
    }

    Console.WriteLine(result);
}