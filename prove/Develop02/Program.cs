using System;
using System.Formats.Asn1;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initialize choice variable and myJournal.
        int choice = 0;
        Journal myJournal = new();

        // Loop options until user selects types 5 to quit.
        while (choice != 5)
        {
            // Options for user to choose from.
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
            choice = int.Parse(answer);

            // Actions to complete base on user choice.
            if (choice == 1)
            // Write a new entry.
            {
                Entry anEntry = new();
                myJournal.AddEntry(anEntry);
            }
            else if (choice == 2)
            // Display all of the entries.
            {
                myJournal.DisplayAll();
            }
            else if (choice == 3)
            // Load entries from a file.
            {
                Console.Write("What file would you like to import (include .txt): ");
                string fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);
            }
            else if (choice == 4)
            // Save entries to a file.
            {
                Console.Write("Name the file (include .txt): ");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }
        }

    }
}