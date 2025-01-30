//3.5 True Alphabetical Order
using System;
using System.Linq;

public class Program
{
    public static string TrueAlphabetic(string s)
    {
        return string.Join(" ", s.Split(' ').Select(word => new string(word.OrderBy(c => c).ToArray())));
    }

    public static void Main()
    {
        Console.WriteLine(TrueAlphabetic("hello world"));
        Console.WriteLine(TrueAlphabetic("edabit is awesome"));
    }
}
