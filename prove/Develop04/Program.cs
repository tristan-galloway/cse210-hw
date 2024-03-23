using System;
using System.Formats.Asn1;
using System.Net;

// I added a conuter for the total of activities completed and a closing message
// as it clears the console.

class Program
{
    static void Main(string[] args)
    {
        int activitiesComplete = 0;
        int response = 0;

        while (response != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string answer = Console.ReadLine();
            response = int.Parse(answer);

            if (response == 1)
            {
                BreathingActivity bactivity = new();
                bactivity.DisplayStartingMessage();
                bactivity.Run();
                bactivity.DisplayEndingMessage();
            }
            else if (response == 2)
            {
                ReflectingActivity ractivity = new();
                ractivity.DisplayStartingMessage();
                ractivity.Run();
                ractivity.DisplayEndingMessage();
            }
            else if (response == 3)
            {
                ListingActivity lactivity = new();
                lactivity.DisplayStartingMessage();
                lactivity.Run();
                lactivity.DisplayEndingMessage();
            }

            activitiesComplete++;
        } 

        Console.Clear();
        Console.WriteLine("Thank you for using the Mindfulness App. Enjoy the rest of your day.");
        Thread.Sleep(5000);
        Console.Clear();
    }
}