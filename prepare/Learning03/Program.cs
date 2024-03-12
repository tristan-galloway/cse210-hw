using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new();
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());

        Fraction five = new(5);
        Console.WriteLine(five.GetFractionString());
        Console.WriteLine(five.GetDecimalValue());

        Fraction threeQuaters = new(3, 4);
        Console.WriteLine(threeQuaters.GetFractionString());
        Console.WriteLine(threeQuaters.GetDecimalValue());

        Fraction oneThird = new(1, 3);
        Console.WriteLine(oneThird.GetFractionString());
        Console.WriteLine(oneThird.GetDecimalValue());
    }
}