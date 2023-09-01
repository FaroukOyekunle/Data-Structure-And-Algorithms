// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

Console.WriteLine("Enter the size of the array (n):");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Enter space-separated integers (a[i]):");
List<int> arrays = new List<int>();

for(int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    arrays.Add(number);
}

int result = PickingNumbers(arrays);
Console.WriteLine("The length of the longest subarray that meets the criterion is: " + result);

static int PickingNumbers(List<int> array)
{
    int[] frequencyArray = new int[101]; 

        
    foreach(int element in array)
    {
        frequencyArray[element]++;
    }

    int maxSubarrayLength = 0;

    for(int i = 0; i < 100; i++)
    {
        maxSubarrayLength = Math.Max(maxSubarrayLength, frequencyArray[i] + frequencyArray[i + 1]);
    }

    return maxSubarrayLength;
}    