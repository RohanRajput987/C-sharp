//Distance based on Speed and Time
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Distance Calculator");
        
      
        Console.Write("Enter speed (in kilometers per hour): ");
        double speed = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter time (in hours): ");
        double time = Convert.ToDouble(Console.ReadLine());
        double distance = speed * time;
        
        Console.WriteLine($"\nThe calculated distance is: {distance} kilometers");
    }
}
