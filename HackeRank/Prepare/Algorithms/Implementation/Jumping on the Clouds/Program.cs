// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to the Cloud Jumping Game!");
        
Console.Write("Enter the total number of clouds: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter the cloud configuration (0 for safe, 1 for thunderclouds): ");
List<int> clouds = new List<int>();
string[] cloudInput = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++)
{
    int cloud = int.Parse(cloudInput[i]);
    clouds.Add(cloud);
}

int result = JumpingOnClouds(clouds);
Console.WriteLine($"Minimum number of jumps required to win the game is: {result}");

static int JumpingOnClouds(List<int> c)
{
    int jumps = 0;
    int i = 0;

    while (i < c.Count - 1)
    {
        if (i + 2 < c.Count && c[i + 2] == 0)
        {
            i += 2;
        }
            
        else
        {
            i++;
        }

        jumps++;
    }

    return jumps;
}