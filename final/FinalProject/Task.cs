using System;

public class Task {
    private string _description;
    private DateTime _deadline ;
    private int _priority ;
    private bool _isCompleted ;

    public Task(string description, DateTime deadline, int priority) {
        _description = description;
        _deadline = deadline;
        _priority = priority;
       _isCompleted = false;
    }

    public string GetDescription() {
        return _description;
    }

    public DateTime GetDeadline() {
        return _deadline;
    }

    public int GetPriority() {
        return _priority;
    }

    public bool IsTaskCompleted() {
        return _isCompleted;
    }

    public void MarkAsCompleted() {
        _isCompleted = true;
    }
}
