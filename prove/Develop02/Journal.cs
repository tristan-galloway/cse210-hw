using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
        newEntry._promptText = GenerateRandomPrompt();
        newEntry.Display();
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine(entry._entryText);
            Console.WriteLine(" ");
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts [2];

            Entry anEntry = new()
            {
                _date = date,
                _promptText = prompt,
                _entryText = response
            };

            _entries.Add(anEntry);
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new(file))
        {
            Console.WriteLine("Saving File...");

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
            }
        }
    }

    public static string GenerateRandomPrompt()
    {
        // List of random journal prompts
        List<string> journalPrompts = new()
        {
            "What are three things you're grateful for today?",
            "Describe a recent challenge you faced and how you overcame it.",
            "Write about a person who has had a significant impact on your life.",
            "If you could travel anywhere in the world where would you go and why?",
            "What are your top five goals for the next year?",
            "Write a letter to your future self.",
            "Describe your ideal day from start to finish.",
            "Reflect on a mistake you've made and what you learned from it."
        };

        // Generate a random prompt
        Random rand = new();
        int index = rand.Next(journalPrompts.Count);

        return journalPrompts[index];

    }
}