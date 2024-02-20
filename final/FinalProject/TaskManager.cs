

public class TaskManager {
    protected List<Task> _tasks;

    public TaskManager() {
        _tasks = new List<Task>();
    }

    public virtual void AddTask(Task task) {
        _tasks.Add(task);
    }

    public virtual void RemoveTask(Task task) {
        _tasks.Remove(task);
    }

    public List<Task> GetTasks() {
        return _tasks;
    }
}
