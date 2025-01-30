//3.7 Clear Brackets
using System;
using System.Linq;

public class Program
{
    public static bool Brackets(string s)
    {
        int balance = 0;
        foreach (var c in s)
        {
            if (c == '(') balance++;
            if (c == ')') balance--;
            if (balance < 0) return false;
        }
        return balance == 0;
    }

    public static void Main()
    {
        Console.WriteLine(Brackets("(a*(b-c)............ )"));
        Console.WriteLine(Brackets(")(a-b-45/7*(a-34))"));
    }
}
