//Arrow pattern
using System;
using System.Collections.Generic;

class ArrowPattern
{
    static List<string> Arrow(int num)
    {
        List<string> pattern = new List<string>();
        for (int i = 1; i <= num; i++)
        {
            pattern.Add(new string('>', i));
        }
        for (int i = (num % 2 == 0 ? num : num - 1); i > 0; i--)
        {
            pattern.Add(new string('>', i));
        }

        return pattern;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number to generate an arrow pattern: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num <= 0)
        {
            Console.WriteLine("Please enter a number greater than 0.");
            return;
        }

        List<string> arrowPattern = Arrow(num);

        Console.WriteLine("\nArrow Pattern:");
        foreach (var row in arrowPattern)
        {
            Console.WriteLine(row);
        }
    }
}
