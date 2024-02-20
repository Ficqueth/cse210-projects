using System;
using System.Collections.Generic;

public class TaskList {
    private List<Task> tasks = new List<Task>();

    public void AddTask(Task task) {
        tasks.Add(task);
    }

    public void RemoveTask(Task task) {
        tasks.Remove(task);
    }

    public void SortTasksByDeadline() {
        tasks.Sort((t1, t2) => t1.Deadline.CompareTo(t2.Deadline));
    }

    public void SortTasksByPriority() {
        tasks.Sort((t1, t2) => t1.Priority.CompareTo(t2.Priority));
    }

    public List<Task> GetIncompleteTasks() {
        return tasks.FindAll(task => !task.IsCompleted);
    }

    public List<Task> GetCompletedTasks() {
        return tasks.FindAll(task => task.IsCompleted);
    }
}
