//break point
using System;
using System.Collections.Generic;

public class DigitCount
{
    public static int DigitCount(int number)
    {
        // Convert the number to a string to process each digit
        string numStr = number.ToString();

        // Dictionary to store the count of each digit
        Dictionary<char, int> digitCount = new Dictionary<char, int>();

        // Count occurrences of each digit
        foreach (char digit in numStr)
        {
            if (digitCount.ContainsKey(digit))
            {
                digitCount[digit]++;
            }
            else
            {
                digitCount[digit] = 1;
            }
        }

        // Create the result number by replacing each digit with its count
        string resultStr = "";
        foreach (char digit in numStr)
        {
            resultStr += digitCount[digit];
        }

        // Convert the result string back to an integer
        return int.Parse(resultStr);
    }

    public static void Main()
    {
        // Test cases
        Console.WriteLine(DigitCount(221333));  // Output: 221333
        Console.WriteLine(DigitCount(136116));  // Output: 312332
        Console.WriteLine(DigitCount(2));       // Output: 1
    }
}
