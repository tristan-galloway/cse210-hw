using System;

class Program
{
    static void Main(string[] args)
    {
        // initializing stopping condition and list
        int answer = -1;
        List<int> numbers = new List<int>();

        // Instructions for user
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Get Numbers
        while (answer != 0)
        {
            Console.Write("Enter number: ");
            string textAnswer = Console.ReadLine();
            answer = int.Parse(textAnswer);
            numbers.Add(answer);
        }

        // Initialize total and largestNum variable
        int total = 0;
        int largestNum = -999999;

        // Compute the sum of the numbers in the list and find the largest number
        foreach (int number in numbers)
        {
            total += number;

            if (number > largestNum)
            {
                largestNum = number;
            }
        }

        // Compute the average
        float average = total / numbers.Count;

        // Return the values to the user
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");

    }
}