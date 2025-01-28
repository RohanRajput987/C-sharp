//Working 9 to 5 
using System;

class Program
{
    public static string OverTime(double[] input)
    {
        double start = input[0]; // Start of working day (in 24-hour format)
        double end = input[1]; // End of working day (in 24-hour format)
        double hourlyRate = input[2]; // Hourly rate
        double overtimeMultiplier = input[3]; // Overtime multiplier
        
        double regularHours = 0;
        double overtimeHours = 0;

        // Calculate regular and overtime hours
        if (start < 17) 
        {
            if (end <= 17)
            {
                regularHours = end - start;
            }
            else
            {
                regularHours = 17 - start;
                overtimeHours = end - 17;
            }
        }
        else
        {
            overtimeHours = end - start;
        }

        // Calculate total earnings
        double regularEarnings = regularHours * hourlyRate;
        double overtimeEarnings = overtimeHours * hourlyRate * overtimeMultiplier;
        double totalEarnings = regularEarnings + overtimeEarnings;

        // Return the formatted output
        return $"${totalEarnings:F2}";
    }

    static void Main()
    {
        
        double[] test1 = { 9, 17, 30, 1.5 };
        double[] test2 = { 16, 18, 30, 1.8 };
        double[] test3 = { 13.25, 15, 30, 1.5 };

        Console.WriteLine(OverTime(test1)); // "$240.00"
        Console.WriteLine(OverTime(test2)); // "$84.00"
        Console.WriteLine(OverTime(test3)); // "$52.50"
    }
}
