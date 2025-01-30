//3.8 Count the number of duplicate Characters
using System;
using System.Linq;

public class Program
{
    public static int DuplicateCount(string s)
    {
        return s.GroupBy(c => c).Count(g => g.Count() > 1);
    }

    public static void Main()
    {
        Console.WriteLine(DuplicateCount("abcde"));
        Console.WriteLine(DuplicateCount("aabbcde"));
    }
}
