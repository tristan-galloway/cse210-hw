using System;

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";

        // A >= 90
        if (grade >= 90)
        {
            letter = "A";
        }
        // B >= 80
        else if (grade >= 80)
        {
            letter = "B";
        }
        // C >= 70
        else if (grade >= 70)
        {
            letter = "C";
        }
        // D >= 60
        else if (grade >= 60)
        {
            letter = "D";
        }
        // F < 60
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade was [{letter}].");

        // Task 2
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine($"Well done you've passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry but your grade was too low this time. Keep studying and come back when you're ready.");
        }

        
    }
}