//Brifcase Lock
using System;

public class BriefcaseLock
{
    public static int MinTurns(string currentLock, string targetLock)
    {
        int totalTurns = 0;
        
        // Loop through each character in the strings
        for (int i = 0; i < currentLock.Length; i++)
        {
            // Get the current digit and target digit as integers
            int currentDigit = int.Parse(currentLock[i].ToString());
            int targetDigit = int.Parse(targetLock[i].ToString());

            // Calculate the forward and backward turns
            int forwardTurns = Math.Abs(targetDigit - currentDigit);
            int backwardTurns = 10 - forwardTurns;

            // Add the minimum of forward and backward turns to the total
            totalTurns += Math.Min(forwardTurns, backwardTurns);
        }

        return totalTurns;
    }

    public static void Main()
    {
        // Test cases
        Console.WriteLine(MinTurns("4089", "5672"));  // Output: 9
        Console.WriteLine(MinTurns("1111", "1100"));  // Output: 2
        Console.WriteLine(MinTurns("2391", "4984"));  // Output: 10
    }
}
