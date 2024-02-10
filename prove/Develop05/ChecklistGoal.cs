using System;

public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _target;
    private int _amountCompleted;

    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string stringChecklistSteps = Console.ReadLine();

        if (!int.TryParse(stringChecklistSteps, out int target))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return; // Exit the method to prevent invalid data
        }
        _target = target;
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonusPoints = Console.ReadLine();

        if (!int.TryParse(bonusPoints, out int bonus))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return; // Exit the method to prevent invalid data
        }
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override bool IsComplete() 
    {
        if (_amountCompleted >= _target) {
            return true;
        } else {
            return false;
        }
    }
    
    public override void RecordEvent()
    {
        _amountCompleted ++;
    }

    public override int CalculateScore()
    {
        int points = 0;

        points = _amountCompleted * _points;

        bool status = IsComplete();

        if (status == true) {
            points += _bonus;
        }

        return points;

    }

    public override void ListGoal()
    {
        string statusSymbol = "";
        bool status = IsComplete();
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }

        Console.Write($"[{statusSymbol}] {_shortName} ({_description}) -- Currently Completed {_amountCompleted}/{_target}");
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"ChecklistGoal:" + _shortName + "," + _description + "," + _points + "," + _bonus + "," + _target + "," + _amountCompleted;
        return line;
    }

}