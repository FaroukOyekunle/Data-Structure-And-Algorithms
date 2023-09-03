// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Enter the number of test cases:");
int t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    Console.WriteLine($"Enter the number of cycles for test case {i + 1}:");
    int n = int.Parse(Console.ReadLine());

    int result = UtopianTree(n);
    Console.WriteLine($"Height after {n} cycles: {result}");
}

static int UtopianTree(int n)
{
    int height = 1; 

    for(int i = 0; i < n; i++)
    {
        if(i % 2 == 0)
        {
            height *= 2;
        }
        
        else
        {
            height += 1;
        }
    }

    return height;
}    