// See https://aka.ms/new-console-template for more information

using System.CodeDom.Compiler;
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
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    Console.WriteLine("Enter the starting and ending point of Sam's house (s t): ");
    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    int s = Convert.ToInt32(firstMultipleInput[0]);
    int t = Convert.ToInt32(firstMultipleInput[1]);

    Console.WriteLine("Enter the location of the Apple and Orange trees (a b): ");
    string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    int a = Convert.ToInt32(secondMultipleInput[0]);
    int b = Convert.ToInt32(secondMultipleInput[1]);

    Console.WriteLine("Enter the number of apples and oranges (m n): ");
    string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    int m = Convert.ToInt32(thirdMultipleInput[0]);
    int n = Convert.ToInt32(thirdMultipleInput[1]);

    Console.WriteLine("Enter the distances that each apple falls from point a: ");
    List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

    Console.WriteLine("Enter the distances that each orange falls from point b: ");
    List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

    countApplesAndOranges(s, t, a, b, apples, oranges);

    static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int appleCount = 0;
        int orangeCount = 0;

        foreach (int apple in apples)
        {
            int applePosition = a + apple;
            if (applePosition >= s && applePosition <= t)
            {
                appleCount++;
            }
        }

        foreach (int orange in oranges)
        {
            int orangePosition = b + orange;
            if (orangePosition >= s && orangePosition <= t)
            {
                orangeCount++;
            }
        }

        Console.WriteLine("Apples that fall on Sam's house: " + appleCount);
        Console.WriteLine("Oranges that fall on Sam's house: " + orangeCount);
    }