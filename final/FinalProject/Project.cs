using System;
using System.Collections.Generic;

public class Project {
    public string ProjectName { get; set; }
    public List<Task> Tasks { get; private set; }

    public Project(string projectName) {
        ProjectName = projectName;
        Tasks = new List<Task>();
    }

    public void AddTask(Task task) {
        Tasks.Add(task);
    }

    public void RemoveTask(Task task) {
        Tasks.Remove(task);
    }

    public void SortTasksByDeadline() {
        Tasks.Sort((t1, t2) => t1.Deadline.CompareTo(t2.Deadline));
    }

    public void SortTasksByPriority() {
        Tasks.Sort((t1, t2) => t1.Priority.CompareTo(t2.Priority));
    }

    public List<Task> GetIncompleteTasks() {
        return Tasks.FindAll(task => !task.IsCompleted);
    }

    public List<Task> GetCompletedTasks() {
        return Tasks.FindAll(task => task.IsCompleted);
    }
}
