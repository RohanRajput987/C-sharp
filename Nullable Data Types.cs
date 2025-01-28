 //Nullable Data Types
using System;

class NullableDataTypes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nullable Data Types Example");

        int nullableInt = null;
        float nullableFloat = 3.14f;
        bool nullableBool = null;


        Console.WriteLine($"Nullable Integer: {nullableInt}");
        Console.WriteLine($"Nullable Float: {nullableFloat}");
        Console.WriteLine($"Nullable Boolean: {nullableBool}");
        nullableInt = 786;
        nullableBool = true;

        Console.WriteLine($"Updated Nullable Integer: {nullableInt}");
        Console.WriteLine($"Updated Nullable Boolean: {nullableBool}");
    }
}
