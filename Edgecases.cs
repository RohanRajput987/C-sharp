//Edge Cases
using System;

class ExploreMathPow
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exploring Edge Cases Using Math.Pow()");

        double result1 = Math.Pow(double.PositiveInfinity, 2);
        Console.WriteLine("Math.Pow(double.PositiveInfinity, 2) = {result1}");
        double result2 = Math.Pow(double.NegativeInfinity, 2);
        Console.WriteLine("Math.Pow(double.NegativeInfinity, 2) = {result2}");
        double result3 = Math.Pow(double.MinValue, 0);
        Console.WriteLine("Math.Pow(double.MinValue, 0) = {result3}");
        double result4 = Math.Pow(double.NaN, 2);
        Console.WriteLine("Math.Pow(double.NaN, 2) = {result4}");
        Console.WriteLine("\nAdditional Edge Cases:");
        double additionalResult1 = Math.Pow(0, 0);
        Console.WriteLine("Math.Pow(0, 0) = {additionalResult1}");
        double additionalResult2 = Math.Pow(10, -1);
        Console.WriteLine("Math.Pow(10, -1) = {additionalResult2}");
        double additionalResult3 = Math.Pow(1, double.MaxValue);
        Console.WriteLine("Math.Pow(1, double.MaxValue) = {additionalResult3}");
    }
}
