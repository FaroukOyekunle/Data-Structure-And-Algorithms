// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Welcome to the Flatland Space Stations Problem!");
        
Console.Write("Enter the total number of cities: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter the indices of cities with space stations separated by spaces: ");
string input = Console.ReadLine();
string[] inputArray = input.Split(' ');
int[] spaceStationIndices = new int[inputArray.Length];

for(int i = 0; i < inputArray.Length; i++)
{
    spaceStationIndices[i] = int.Parse(inputArray[i]);
}

int result = FlatlandSpaceStations(n, spaceStationIndices);
Console.WriteLine($"The maximum distance is: {result}");
    
   
static int FlatlandSpaceStations(int n, int[] c)
{
    Array.Sort(c);

    int maximumDistance = 0;
    int previousStation = -1;

    for(int i = 0; i < c.Length; i++)
    {
        int currentStation = c[i];
        int distance;

        if(previousStation == -1)
        {
            distance = currentStation;
        }
        
        else
        {
            distance = (currentStation - previousStation) / 2;
        }

        maximumDistance = Math.Max(maximumDistance, distance);

        previousStation = currentStation;
    }

    int lastDistance = n - 1 - previousStation;
    maximumDistance = Math.Max(maximumDistance, lastDistance);

    return maximumDistance;
}