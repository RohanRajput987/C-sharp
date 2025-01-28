//Random Number Generator
using System;
using System.Collections.Generic;

class RandomNumberGenerator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Random Number Generator");
        Console.Write("Enter the number of random numbers to generate: ");
        int count = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the minimum value of the range: ");
        int min = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the maximum value of the range: ");
        int max = Convert.ToInt32(Console.ReadLine());
        if (count > (max - min + 1))
        {
            Console.WriteLine("Error: Cannot generate unique numbers with the given range and count.");
            return;
        }
        Random rand = new Random();
        HashSet<int> randomNumbers = new HashSet<int>();

        while (randomNumbers.Count < count)
        {
            randomNumbers.Add(rand.Next(min, max + 1));
        }
        Console.WriteLine("Generated random numbers:");
        foreach (var num in randomNumbers)
        {
            Console.Write(num + " ");
        }
    }
}
