using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _status;

    public Goal() 
    {
        _shortName = "Test Name";
        _description = "Test Description";
        _points = 10;
        _status = false;
    }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    protected void CreateBaseGoal() 
    {   
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string stringGoalPoints = Console.ReadLine();
        _points = Convert.ToInt32(stringGoalPoints);

        _status = false;
    }

    public virtual string SaveGoal()
    {
        return "" ;
    }

    public abstract void CreateChildGoal();

    public abstract void RecordEvent();

    public virtual bool IsComplete() 
    {
        return false;
    }

    public abstract void ListGoal();

    public virtual int CalculateScore()
    {
        return 0;
    }


}