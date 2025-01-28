//new driving license
using System;
using System.Linq;

class Program
{
    public static int License(string me, int agents, string others)
    {
        // Combine your name with the others and sort them alphabetically
        var allNames = others.Split(' ').Append(me).OrderBy(name => name).ToArray();

        // Find your position in the sorted list
        int myPosition = Array.IndexOf(allNames, me);

        // Calculate the number of groups (since we have agents available to process people in parallel)
        int groupNumber = myPosition / agents;

        // The time taken will be the number of groups * 20 minutes
        return (groupNumber + 1) * 20;
    }

    static void Main()
    {
        // Test cases
        Console.WriteLine(License("Eric", 2, "Adam Caroline Rebecca Frank")); // Expected: 40
        Console.WriteLine(License("Zebediah", 1, "Bob Jim Becky Pat"));        // Expected: 100
        Console.WriteLine(License("Aaron", 3, "Jane Max Olivia Sam"));         // Expected: 20
    }
}
