using System;

public class EternalGoal : Goal
{
    private int _amountCompleted;

    public EternalGoal()
    {

    }
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    public override void ListGoal()
    {
        Console.Write($"[ ] {_shortName} ({_description})");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"EternalGoal:" + _shortName + "," + _description + "," + _points;
        return line;
    }

    public override void RecordEvent()
    {
        _amountCompleted ++;
    }
    public override int CalculateScore()
    {
        int points = _points;
        return points;
    }
}