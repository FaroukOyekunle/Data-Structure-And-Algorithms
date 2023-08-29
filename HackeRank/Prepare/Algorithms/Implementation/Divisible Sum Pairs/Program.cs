// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */


    string[] firstLine = Console.ReadLine()?.Split(' ');

        if (firstLine == null || firstLine.Length < 2)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        int n = Convert.ToInt32(firstLine[0]);
        int k = Convert.ToInt32(firstLine[1]);

        List<int> array = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            array.Add(num);
        }

        int result = CountDivisibleSumPairs(n, k, array);

        Console.WriteLine(result);

    static int CountDivisibleSumPairs(int n, int k, List<int> array)
    {
        int count = 0;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if ((array[i] + array[j]) % k == 0)
                    count++;
            }
        }

        return count;
    }