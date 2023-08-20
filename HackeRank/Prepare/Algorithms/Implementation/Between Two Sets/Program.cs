// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    Console.WriteLine("Enter the number of elements in arrays a and b (n m):");
    int[] firstMultipleInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    int n = firstMultipleInput[0];
    int m = firstMultipleInput[1];

    Console.WriteLine("Enter the elements of array a:");
    List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

    Console.WriteLine("Enter the elements of array b:");
    List<int> brr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

    int total = getTotalX(arr, brr);

    Console.WriteLine("Number of integers between the sets: " + total);

    static int getTotalX(List<int> a, List<int> b)
    {
        int count = 0;

        for (int num = 1; num <= 100; num++)
        {
            bool factorOfA = true;
            foreach (int aValue in a)
            {
                if (num % aValue != 0)
                {
                    factorOfA = false;
                    break;
                }
            }

            bool factorOfB = true;
            foreach (int bValue in b)
            {
                if (bValue % num != 0)
                {
                    factorOfB = false;
                    break;
                }
            }

            if (factorOfA && factorOfB)
            {
                count++;
            }
        }

        return count;
    }    