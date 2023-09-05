// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Enter the number of clouds and jump distance (n k):");
string[] input = Console.ReadLine().Split(' ');

int n = int.Parse(input[0]);
int k = int.Parse(input[1]);

Console.WriteLine("Enter space-separated cloud types (0 for cumulus, 1 for thunderhead):");
string[] cloudTypes = Console.ReadLine().Split(' ');
int[] clouds = new int[n];

for(int i = 0; i < n; i++)
{
    clouds[i] = int.Parse(cloudTypes[i]);
}

int energy = JumpingOnClouds(clouds, k);

Console.WriteLine("The remaining energy level: " + energy);

static int JumpingOnClouds(int[] clouds, int jumpDistance)
{
    int n = clouds.Length;
    int energy = 100;
    int currentPosition = 0;

    do
    {
        currentPosition = (currentPosition + jumpDistance) % n;
        energy -= clouds[currentPosition] * 2 + 1;
    } while (currentPosition != 0);

    return energy;
}    