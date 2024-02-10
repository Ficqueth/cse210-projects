using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _score = 0;

    public int DisplayPlayerInfo() {

        int points = _score;
        return points;

    }
    public void SaveGoals()
    {

        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int totalScore = DisplayPlayerInfo();
            outputFile.WriteLine(totalScore.ToString());
            
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear(); 

        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _score = Convert.ToInt32(lines[0]);

        for (int i = 1; i < lines.Count(); i++ )
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal") {

                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                _goals.Add(simpleGoal);             

            } else if (parts[0] == "EternalGoal") {

                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                _goals.Add(eternalGoal);

            } else if (parts[0] == "ChecklistGoal") {
                
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                _goals.Add(checklistGoal);

            }
        }

    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++) {
            Console.Write($"{i + 1}. ");
            _goals[i].ListGoal();
            Console.Write("\n");
        }
        Console.WriteLine();
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEventInTracker()
    {

        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        string goalIndex = Console.ReadLine();

        if (int.TryParse(goalIndex, out int goalIndexInt))
        {
            goalIndexInt--;
            if (goalIndexInt >= 0 && goalIndexInt < _goals.Count)
            {
                if (_goals[goalIndexInt].IsComplete() == false)
                {
                    _goals[goalIndexInt].RecordEvent();
                    int pointsEarned = _goals[goalIndexInt].CalculateScore();
                    _score += pointsEarned;
                    Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                    Console.WriteLine($"You now have {_score} points");
                }
                else
                {
                    Console.WriteLine("You have already completed this goal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid goal index. Please enter a number between 1 and {0}.", _goals.Count);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}