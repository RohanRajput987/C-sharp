//Bitwise Operator
using System;

class BitwiseOperators
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitwise Operators Example");
        Console.Write("Enter the first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

       
        Console.WriteLine("Bitwise AND ({num1} & {num2}) = {num1 & num2}");
        Console.WriteLine("Bitwise OR ({num1} | {num2}) = {num1 | num2}");
        Console.WriteLine("Bitwise XOR ({num1} ^ {num2}) = {num1 ^ num2}");
        Console.WriteLine("Bitwise NOT (~{num1}) = {~num1}");
        Console.WriteLine("Left Shift ({num1} << 2) = {num1 << 2}");
        Console.WriteLine("Right Shift ({num1} >> 2) = {num1 >> 2}");
    }
}
