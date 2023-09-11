// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Welcome to the Library Fine Calculator");

Console.WriteLine("Enter the return date (day month year):");
Console.Write("Day (1-31): ");
int day1 = int.Parse(Console.ReadLine());

Console.Write("Month (1-12): ");
int month1 = int.Parse(Console.ReadLine());

Console.Write("Year: ");
int year1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the due date (day month year):");
Console.Write("Day (1-31): ");
int day2 = int.Parse(Console.ReadLine());

Console.Write("Month (1-12): ");
int month2 = int.Parse(Console.ReadLine());

Console.Write("Year: ");
int year2 = int.Parse(Console.ReadLine());

int fine = LibraryFine(day1, month1, year1, day2, month2, year2);
        
if(fine == 0)
{
    Console.WriteLine("No fine is charged.");
}
else
{
    Console.WriteLine($"Fine: {fine} Hackos");
}

static int LibraryFine(int day1, int month1, int year1, int day2, int month2, int year2)
{
    if (year1 < year2 || (year1 == year2 && month1 < month2) || (year1 == year2 && month1 == month2 && day1 <= day2))
    {
        return 0;
    }

    else if (year1 == year2 && month1 == month2)
    {
        return 15 * (day1 - day2);
    }
        
    else if (year1 == year2 && month1 > month2)
    {
        return 500 * (month1 - month2);
    }

    else
    {
        return 10000;
    }
}