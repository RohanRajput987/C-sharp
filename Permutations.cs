//Permutations(nPr)
using System;

class Permutations
{
    static long Factorial(int x)
    {
        if (x == 0 || x == 1)
            return 1;
        return x * Factorial(x - 1);
    }

    static long CalculatePermutations(int n, int r)
    {
        return Factorial(n) / Factorial(n - r);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Permutations Calculator");

        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of r: ");
        int r = Convert.ToInt32(Console.ReadLine());
        if (r > n)
        {
            Console.WriteLine("Error: r cannot be greater than n.");
            return;
        }
        long result = CalculatePermutations(n, r);
        Console.WriteLine("Number of permutations ({n}P{r}) = {result}");
    }
}
