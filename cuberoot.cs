//Cube root
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cube Root Calculator");
        Console.Write("Enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());
        double cubeRoot = Math.Cbrt(number);
        Console.WriteLine($"\nThe cube root of {number} is: {cubeRoot}");
    }
}
