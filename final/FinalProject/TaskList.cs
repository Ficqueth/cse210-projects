public class TaskList : TaskManager {
    public TaskList() : base() {}

    public void SortTasksByDeadline() {
        _tasks.Sort((t1, t2) => t1.GetDeadline().CompareTo(t2.GetDeadline()));
    }

    public void SortTasksByPriority() {
        _tasks.Sort((t1, t2) => t1.GetPriority().CompareTo(t2.GetPriority()));
    }

    public List<Task> GetIncompleteTasks() {
        return _tasks.FindAll(task => !task.IsTaskCompleted());
    }

    public List<Task> GetCompletedTasks() {
        return _tasks.FindAll(task => task.IsTaskCompleted());
    }

    public override void AddTask(Task task) {
        if (task.GetPriority() > 0) {
            base.AddTask(task);
        }
        else {
            Console.WriteLine("Task priority must be greater than 0.");
        }
    }
    public override void RemoveTask(Task task) {
        // Perform additional cleanup if needed
        base.RemoveTask(task); // Call base implementation
    }
}