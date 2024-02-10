using System;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {

    }

    public SimpleGoal(string name, string description, int points, bool status)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _status = status;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    public override void RecordEvent()
    {
        if (_status == false) {
            _status = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        if (_status == true) {
            return true;
        } else {
            return false;
        }
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
        Console.Write($"[{statusSymbol}] {_shortName} ({_description})");
    }
    
    public override int CalculateScore()
    {
        bool status = IsComplete();
        int score = 0;
        if (status == true) {
            score = _points;
        } else {
            score = 0;
        }
        return score;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"SimpleGoal:{_shortName},{_description}{_points},{IsComplete()}";
        return line;
    }
}