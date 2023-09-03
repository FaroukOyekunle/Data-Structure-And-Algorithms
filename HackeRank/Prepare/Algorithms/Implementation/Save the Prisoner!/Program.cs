// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Enter the number of test cases:");
int t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    Console.WriteLine($"Test Case {i + 1}");
            
    Console.WriteLine("Enter the number of prisoners:");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the number of sweets:");
    int m = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the chair number to start passing out treats at:");
    int s = int.Parse(Console.ReadLine());

    int result = SaveThePrisoner(n, m, s);
    Console.WriteLine($"Prisoner to warn: {result}");
}

static int SaveThePrisoner(int n, int m, int s)
{
    int prisonerToWarn = (s + m - 2) % n + 1;
        
    return prisonerToWarn;
}