

public class TaskList : TaskManager{
    private List<Task> _tasks = new List<Task>();

    public void SortTasksByDeadline() {
        _tasks.Sort((t1, t2) => t1.GetDeadline().CompareTo(t2.GetDeadline()));
    }

    public void SortTasksByPriority() {
        _tasks.Sort((t1, t2) => t1.GetDeadline().CompareTo(t2.GetDeadline()));
    }

    public List<Task> GetIncompleteTasks() {
        return _tasks.FindAll(task => !task.IsTaskCompleted());
    }

    public List<Task> GetCompletedTasks() {
        return _tasks.FindAll(task => task.IsTaskCompleted());
    }
}
