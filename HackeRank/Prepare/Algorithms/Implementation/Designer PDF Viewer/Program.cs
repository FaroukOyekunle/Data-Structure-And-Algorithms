// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

List<int> h = new List<int>();
Console.WriteLine("Enter number of heights- then enter the word beneath: ");

string[] hItems = Console.ReadLine().Trim().Split(' ');  

foreach(string hItem in hItems)
{
    h.Add(Convert.ToInt32(hItem));
}

    string word = Console.ReadLine();

    int result = DesignerPdfViewer(h, word);

    Console.WriteLine(result);

static int DesignerPdfViewer(List<int> h, string word)
{
    int maxHeight = 0;

    foreach(char c in word)
    {
        int index = c - 'a';
        maxHeight = Math.Max(maxHeight, h[index]);
    }

    return maxHeight * word.Length;
}