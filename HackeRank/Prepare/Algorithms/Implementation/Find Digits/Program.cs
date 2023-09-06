// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Enter the number of test cases:");
int testCase = int.Parse(Console.ReadLine());

for(int i = 0; i < testCase; i++)
{
    Console.WriteLine("Enter the integer to analyze:");
    int userInput = int.Parse(Console.ReadLine());

    int result = FindDigits(userInput);

    Console.WriteLine("The number of divisors in the integer: " + result);
}

static int FindDigits(int number)
{
    int originalNumber = number;
    int count = 0;

    while(number > 0)
    {
        int digit = number % 10; 
        if(digit != 0 && originalNumber % digit == 0)
        {
            count++;
        }
        number /= 10; 
    }

    return count;
}