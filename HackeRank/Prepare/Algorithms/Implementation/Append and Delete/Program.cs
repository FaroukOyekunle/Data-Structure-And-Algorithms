// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Enter the initial string:");
string s = Console.ReadLine();

Console.WriteLine("Enter the desired final string:");
string t = Console.ReadLine();

Console.WriteLine("Enter the number of operations:");
int k = int.Parse(Console.ReadLine());

bool result = CanConvertInitialStringSToK(s, t, k);
Console.WriteLine(result ? "Yes" : "No");  // Complete the 'appendAndDelete' function below.

static int FindCommonLengthBetweenTwoStrings(string s, string t)
{
    int commonLength = 0;

        for(int i = 0; i < Math.Min(s.Length, t.Length); i++)
        {
            if (s[i] == t[i])
            {
                commonLength++;
            }
            else
            {
                break;
            }
        }

        return commonLength;
    }

static bool CanConvertInitialStringSToK(string s, string t, int k)
{
    int commonLength = FindCommonLengthBetweenTwoStrings(s, t);
    int totalOperations = s.Length - commonLength + t.Length - commonLength;

    return k >= s.Length + t.Length || (k >= totalOperations && (k - totalOperations) % 2 == 0) || k >= s.Length + t.Length;
}