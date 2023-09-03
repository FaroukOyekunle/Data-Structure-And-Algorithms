// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

Console.WriteLine("Enter the number of test cases:");
int t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    Console.WriteLine($"Test Case {i + 1}");
            
    Console.WriteLine("Enter the number of students and the cancellation threshold:");
    string[] input1 = Console.ReadLine().Split(' ');

    int n = int.Parse(input1[0]);
    int k = int.Parse(input1[1]);

    Console.WriteLine("Enter the arrival times of the students separated by spaces:");
    string[] input2 = Console.ReadLine().Split(' ');

    List<int> arrivalTimes = new List<int>();
    for (int j = 0; j < n; j++)
    {
        arrivalTimes.Add(int.Parse(input2[j]));
    }

    string result = AngryProfessor(k, arrivalTimes);
    Console.WriteLine($"Class Status: {result}");
}

static string AngryProfessor(int k, List<int> a)
{
    int onTimeCount = 0;

    foreach(int arrivalTime in a)
    {
        if(arrivalTime <= 0)
        {
            onTimeCount++;
        }
    }

    return onTimeCount < k ? "YES" : "NO";
}
