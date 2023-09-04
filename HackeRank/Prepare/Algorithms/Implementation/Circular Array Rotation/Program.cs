// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

Console.WriteLine("Enter the number of elements, rotation count, and number of queries:");
string[] input1 = Console.ReadLine().Split(' ');

int n = int.Parse(input1[0]);
int k = int.Parse(input1[1]);
int q = int.Parse(input1[2]);

Console.WriteLine("Enter the elements of the array:");
List<int> a = new List<int>();

for(int i = 0; i < n; i++)
{
    a.Add(int.Parse(Console.ReadLine()));
}

List<int> queries = new List<int>();
Console.WriteLine("Enter the indices to report:");
for(int i = 0; i < q; i++)
{
    queries.Add(int.Parse(Console.ReadLine()));
}

List<int> result = CircularArrayRotation(a, k, queries);

Console.WriteLine("Values in the rotated array as requested:");
foreach(int val in result)
{
    Console.WriteLine(val);
}

static List<int> CircularArrayRotation(List<int> a, int k, List<int> queries)
{
    int n = a.Count;
    List<int> result = new List<int>();

    int effectiveRotations = k % n;

    List<int> rotatedArray = new List<int>();

    for(int i = n - effectiveRotations; i < n; i++)
    {
        rotatedArray.Add(a[i]);
    }

    for(int i = 0; i < n - effectiveRotations; i++)
    {
        rotatedArray.Add(a[i]);
    }

    foreach(int query in queries)
    {
        result.Add(rotatedArray[query]);
    }

    return result;
}    