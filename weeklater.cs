//3.3 A week later
using System;
using System.Globalization;

public class Program
{
    public static string WeekAfter(string date)
    {
        DateTime dt = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime newDate = dt.AddDays(7);
        return newDate.ToString("dd/MM/yyyy");
    }

    public static void Main()
    {
        Console.WriteLine(WeekAfter("12/03/2020"));
        Console.WriteLine(WeekAfter("21/12/1989"));
    }
}
