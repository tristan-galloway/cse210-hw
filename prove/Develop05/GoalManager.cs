using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.IO;
using System.Linq;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string answer = Console.ReadLine();
        int choice = int.Parse(answer);

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string pointsString = Console.ReadLine();
        int points = int.Parse(pointsString);

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                answer = Console.ReadLine();
                int target = int.Parse(answer);
                Console.Write("What is the bonus for accomplishing it that many times? ");
                answer = Console.ReadLine();
                int bonus = int.Parse(answer);

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;    
        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.GetDetailsString()}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{g.GetStringRepresentation()}");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using StreamWriter outputFile = new(fileName);
        outputFile.WriteLine(_score);
        foreach (Goal g in _goals)
        {
            outputFile.WriteLine($"{g.GetStringRepresentation()}");
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        //Pass the file path and file name to the StreamReader constructor
        StreamReader sr = new(fileName);
        //Read the first line of text
        string line;
        line = sr.ReadLine();
        int currentPoints = int.Parse(line);
        _score = currentPoints;
        //Read the next line
        line = sr.ReadLine();
        //Continue to read until you reach end of file
        while (line != null)
        {
            string[] parts = line.Split(",");

            string objectType = parts[0];
            string name = parts[1];
            string description = parts[2];
            string pointsString = parts[3];
            int points = int.Parse(pointsString);
            
            if (objectType == "SimpleGoal")
            {
                string isCompleteString = parts[4];
                bool isComplete = bool.Parse(isCompleteString);
                _goals.Add(new SimpleGoal(name, description, points, isComplete));
            }
            else if (objectType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (objectType == "ChecklistGoal")
            {
                string bonusString = parts[4];
                string targetString = parts[5];
                string qtyCompletedString = parts[6];
                int bonus = int.Parse(bonusString);
                int target = int.Parse(targetString);
                int qtyCompleted = int.Parse(qtyCompletedString);
                _goals.Add(new ChecklistGoal(name, description, points, bonus, target, qtyCompleted));
            }
            //Read the next line
            line = sr.ReadLine();
        }
        //close the file
        sr.Close();
    }

    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        string answer = Console.ReadLine();
        int index = int.Parse(answer) - 1;

        _goals[index].RecordEvent();
        _score += _goals[index].GetPoints();

        Console.WriteLine($"You now have {_score} points.");
    }
}