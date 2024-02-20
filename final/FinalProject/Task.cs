using System;

public class Task {
    public string _description { get; set; }
    public DateTime _deadline { get; set; }
    public int _priority { get; set; }
    public bool _isCompleted { get; set; }

    public Task(string description, DateTime deadline, int priority) {
        _description = description;
        _deadline = deadline;
        _priority = priority;
       _isCompleted = false;
    }

    public void MarkAsCompleted() {
        _isCompleted = true;
    }
}
