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
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    Console.WriteLine("Enter the starting position and jump distance for Kangaroo 1 (x1 v1): ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int v1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the starting position and jump distance for Kangaroo 2 (x2 v2): ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    int v2 = Convert.ToInt32(Console.ReadLine());

    string result = kangaroo(x1, v1, x2, v2);

    Console.WriteLine("Result: " + result);

    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 == v2)
        {
            if (x1 == x2)
            {
                return "YES";
            }
            else
            {   
                return "NO";
            }
        }

        int jumpCount = (x2 - x1) / (v1 - v2);

        if (jumpCount >= 0 && (x1 + jumpCount * v1) == (x2 + jumpCount * v2))
        { 
            return "YES";
        }
        else
        {
            return "NO";
        }
    }