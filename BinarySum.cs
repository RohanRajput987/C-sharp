//Binary Sum
using System;

class BinarySum
{
    static bool IsBinary(string binary)
    {
        foreach (char c in binary)
        {
            if (c != '0' && c != '1')
                return false;
        }
        return true;
    }

    static string AddBinary(string a, string b)
    {
        int num1 = Convert.ToInt32(a, 2);
        int num2 = Convert.ToInt32(b, 2);
        int sum = num1 + num2;

        return Convert.ToString(sum, 2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Binary Sum Calculator");

        Console.Write("Enter the first binary number: ");
        string binary1 = Console.ReadLine();

        Console.Write("Enter the second binary number: ");
        string binary2 = Console.ReadLine();

       
        if (!IsBinary(binary1) || !IsBinary(binary2))
        {
            Console.WriteLine("Error: One or both inputs are not valid binary numbers.");
            return;
        }


        string result = AddBinary(binary1, binary2);
        Console.WriteLine($"Sum of {binary1} and {binary2} is {result}");
    }
}
