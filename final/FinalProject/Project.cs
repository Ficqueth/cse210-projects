
public class Project {
    private string _projectName;
    private List<Task> _tasks;

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
