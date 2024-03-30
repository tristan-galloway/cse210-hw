using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{
    private int _qtyCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int bonus, int target) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _qtyCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int points, int bonus, int target, int qtyCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _qtyCompleted = qtyCompleted;
    }

    public override void RecordEvent()
    {
        _qtyCompleted ++;

        if (_target == _qtyCompleted)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            Console.WriteLine($"Because you've finished reached your targeted time doing this task, you've recieved {_bonus} bonus points");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    }

    public override bool IsComplete()
    {
        if (_qtyCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int GetPoints()
    {
        return _points + _bonus;
    }

    public override string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[X] {_shortName} ({_description}) -- {_qtyCompleted}/{_target}";
        }
        else 
        {
            return $"[ ] {_shortName} ({_description}) -- {_qtyCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
       return $"ChecklistGoal,{_shortName},{_description},{_points},{_bonus},{_target},{_qtyCompleted}";
    }

}