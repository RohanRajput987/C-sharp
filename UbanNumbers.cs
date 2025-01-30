//3.9 Uban Numbers
using System;
using System.Text;

public class Program
{
    public static bool IsUban(int n)
    {
        string numberInWords = NumberToWords(n);
        return !numberInWords.Contains("u");
    }

    private static string NumberToWords(int number)
    {
        // Simple case for this example. You can extend this logic using a number-to-words library.
        var units = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        if (number <= 10) return units[number - 1];
        return number.ToString(); // Simplified case
    }

    public static void Main()
    {
        Console.WriteLine(IsUban(456)); // False
        Console.WriteLine(IsUban(25));  // True
    }
}
