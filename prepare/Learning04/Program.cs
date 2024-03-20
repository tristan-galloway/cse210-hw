using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment math = new("Tristan Galloway", "Math");

        Console.WriteLine(math.GetSummary());
    }
}