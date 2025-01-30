//3.1 Find the bomb
using System;

public class Program
{
    public static string Bomb(string s)
    {
        if (s.ToLower().Contains("bomb"))
        {
            return "Duck!!!";
        }
        return "There is no bomb, relax.";
    }

    public static void Main()
    {
        Console.WriteLine(Bomb("There is a bomb."));
        Console.WriteLine(Bomb("This goes boom!!!"));
    }
}
