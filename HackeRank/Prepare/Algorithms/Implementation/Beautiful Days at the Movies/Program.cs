// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Enter the starting day (i):");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the ending day (j):");
int j = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the divisor (k):");
int k = Convert.ToInt32(Console.ReadLine());

int result = BeautifulDays(i, j, k);
Console.WriteLine("Number of beautiful days: " + result);

static int BeautifulDays(int i, int j, int k)
{
    int beautifulCount = 0;

    for(int day = i; day <= j; day++)
    {
        int reversedDay = ReverseNumber(day);
        int difference = Math.Abs(day - reversedDay);

        if(difference % k == 0)
        {
            beautifulCount++;
        }
    }

    return beautifulCount;
}

static int ReverseNumber(int num)
{
    int reversed = 0;

    while(num > 0)
    {
        int digit = num % 10;
        reversed = reversed * 10 + digit;
        num /= 10;
    }

    return reversed;
} 