//the day rob was born in dutch
using System;
using System.Globalization;

public class Weekday
{
    public static string WeekdayRobWasBornInDutch(int year, int month, int day)
    {
        // Create a DateTime object with the given year, month, and day
        DateTime date = new DateTime(year, month, day);

        // Get the Dutch culture info
        CultureInfo dutchCulture = new CultureInfo("nl-NL");

        // Return the weekday name in Dutch
        return date.ToString("dddd", dutchCulture).ToLower();  // Use ToLower() for lowercase output
    }

    public static void Main()
    {
        // Test cases
        Console.WriteLine(WeekdayRobWasBornInDutch(1970, 9, 21)); // "maandag"
        Console.WriteLine(WeekdayRobWasBornInDutch(1945, 9, 2));  // "zondag"
        Console.WriteLine(WeekdayRobWasBornInDutch(2001, 9, 11)); // "dinsdag"
    }
}
