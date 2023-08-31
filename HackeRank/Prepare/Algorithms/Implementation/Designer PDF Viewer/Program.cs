// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

List<int> letterHeights = new List<int>();

        Console.WriteLine("Enter the heights of each lowercase English letter (a-z), separated by spaces:");
        string heightsInput = Console.ReadLine();
        string[] heights = heightsInput.Split(' ');

        foreach (string height in heights)
        {
            int heightValue = Convert.ToInt32(height);
            letterHeights.Add(heightValue);
        } 

        Console.WriteLine("Enter a word consisting of lowercase English alphabetic letters:");
        string word = Console.ReadLine();

        int area = DesignerPdfViewer(letterHeights, word);
        Console.WriteLine("The highlighted area is: " + area);

static int DesignerPdfViewer(List<int> letterHeights, string word)
{
    int maxHeight = 0;

    foreach (char c in word)
    {
        int index = c - 'a';
        maxHeight = Math.Max(maxHeight, letterHeights[index]);
    }

    return maxHeight * word.Length;
}


// using System;
// using System.Collections.Generic;

// class Solution
// {
//     public static int DesignerPdfViewer(List<int> letterHeights, string word)
//     {
//         int maxHeight = 0;

//         foreach (char c in word)
//         {
//             int index = c - 'a';
//             maxHeight = Math.Max(maxHeight, letterHeights[index]);
//         }

//         return maxHeight * word.Length;
//     }

//     public static void Main(string[] args)
//     {
//         List<int> letterHeights = new List<int>();

//         Console.WriteLine("Enter the heights of each lowercase English letter (a-z), separated by spaces:");
//         string heightsInput = Console.ReadLine();
//         string[] heights = heightsInput.Split(' ');

//         foreach (string height in heights)
//         {
//             int heightValue = Convert.ToInt32(height);
//             letterHeights.Add(heightValue);
//         }

//         Console.WriteLine("Enter a word consisting of lowercase English alphabetic letters:");
//         string word = Console.ReadLine();

//         int area = DesignerPdfViewer(letterHeights, word);
//         Console.WriteLine("The highlighted area is: " + area);
//     }
// }
