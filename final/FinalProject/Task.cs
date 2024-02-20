using System;

public class Task {
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    public int Priority { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string description, DateTime deadline, int priority) {
        Description = description;
        Deadline = deadline;
        Priority = priority;
        IsCompleted = false;
    }

    public void MarkAsCompleted() {
        IsCompleted = true;
    }
}
