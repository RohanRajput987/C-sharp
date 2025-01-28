//No math
using System;

class NoMathExample
{
   
    static double CalculateSquareRoot(double number)
    {
        if (number < 0)
        {
            Console.WriteLine("Square root of negative numbers is not real.");
            return double.NaN;
        }

        double guess = number / 2.0;
        double epsilon = 0.00001; // Tolerance for approximation

        while (Math.Abs(guess * guess - number) > epsilon)
        {
            guess = (guess + number / guess) / 2.0;
        }

        return guess;
    }

    
    static double FindAbsoluteValue(double number)
    {
        return number < 0 ? -number : number;
    }

    static void Main(string[] args)
    {
        
        Console.Write("Enter a number to find its square root: ");
        double squareRootInput = Convert.ToDouble(Console.ReadLine());
        double squareRootResult = CalculateSquareRoot(squareRootInput);
        Console.WriteLine($"Square root of {squareRootInput} is approximately: {squareRootResult}");

       
        Console.Write("Enter a number to find its absolute value: ");
        double absoluteValueInput = Convert.ToDouble(Console.ReadLine());
        double absoluteValueResult = FindAbsoluteValue(absoluteValueInput);
        Console.WriteLine($"Absolute value of {absoluteValueInput} is: {absoluteValueResult}");
    }
}
