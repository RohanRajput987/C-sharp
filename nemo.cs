//3.2 finding Nemo
using System;

public class Program
{
    public static string FindNemo(string s)
    {
        string[] words = s.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == "Nemo")
            {
                return $"I found Nemo at {i + 1}!";
            }
        }
        return "I can't find Nemo :(";
    }

    public static void Main()
    {
        Console.WriteLine(FindNemo("I am finding Nemo !"));
        Console.WriteLine(FindNemo("Nemo is me"));
    }
}
