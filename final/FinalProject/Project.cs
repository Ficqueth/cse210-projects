using System;
using System.Collections.Generic;

public class Project {
    public string _projectName { get; set; }
    public List<Task> _tasks { get; private set; }

    public Project(string projectName) {
        _projectName = projectName;
        _tasks = new List<Task>();
    }

    public void AddTask(Task task) {
        _tasks.Add(task);
    }

    public void RemoveTask(Task task) {
        _tasks.Remove(task);
    }

    public void SortTasksByDeadline() {
        _tasks.Sort((t1, t2) => t1.Deadline.CompareTo(t2.Deadline));
    }

    public void SortTasksByPriority() {
        _tasks.Sort((t1, t2) => t1.Priority.CompareTo(t2.Priority));
    }

    public List<Task> GetIncompleteTasks() {
        return _tasks.FindAll(task => !task.IsCompleted);
    }

    public List<Task> GetCompletedTasks() {
        return _tasks.FindAll(task => task.IsCompleted);
    }
}
