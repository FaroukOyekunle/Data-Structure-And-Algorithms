// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Welcome to the Array Equalization Program!");

Console.Write("Enter the number of elements in the array: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter the array elements separated by spaces: ");
List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int result = EqualizeArray(arr);
Console.WriteLine($"Minimum number of deletions required is: {result}");

static int EqualizeArray(List<int> arr)
{
    Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

    foreach (int num in arr)
    {
        if (frequencyMap.ContainsKey(num))
        {
            frequencyMap[num]++;
        }
            
        else
        {
            frequencyMap[num] = 1;
        }
    }

    int maximumFrequency = frequencyMap.Values.Max();

    int minimumDeletions = arr.Count - maximumFrequency;

    return minimumDeletions;
}   