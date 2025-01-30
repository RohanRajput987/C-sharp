//3.5 Longest Common Ending
using System;

public class Program
{
    public static string LongestCommonEnding(string str1, string str2)
    {
        int minLength = Math.Min(str1.Length, str2.Length);
        int i = 0;
        while (i < minLength && str1[str1.Length - 1 - i] == str2[str2.Length - 1 - i])
        {
            i++;
        }
        return str1.Substring(str1.Length - i);
    }

    public static void Main()
    {
        Console.WriteLine(LongestCommonEnding("multiplication", "ration"));
        Console.WriteLine(LongestCommonEnding("skyscraper", "carnivore"));
    }
}
