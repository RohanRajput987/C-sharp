//smallest missing positive integer
using System;
using System.Collections.Generic;
using System.Linq;

public class SmallestMissingPositive
{
    public static int MinMissPos(int[] arr)
    {
        // Remove negative numbers and zeros, only keep positive numbers
        HashSet<int> positiveNumbers = new HashSet<int>();
        
        foreach (var num in arr)
        {
            if (num > 0)
            {
                positiveNumbers.Add(num);
            }
        }

        // Starting from 1, find the first missing positive integer
        int smallestMissing = 1;
        while (positiveNumbers.Contains(smallestMissing))
        {
            smallestMissing++;
        }

        return smallestMissing;
    }

    public static void Main()
    {
        // Test cases
        Console.WriteLine(MinMissPos(new int[] { -2, 6, 4, 5, 7, -1, 1, 3, 6, -2, 9, 10, 2, 2 }));  // Output: 8
        Console.WriteLine(MinMissPos(new int[] { 5, 9, -2, 0, 1, 3, 9, 3, 8, 9 }));  // Output: 2
        Console.WriteLine(MinMissPos(new int[] { 0, 4, 4, -1, 9, 4, 5, 2, 10, 7, 6, 3, 10, 9 }));  // Output: 1
    }
}
