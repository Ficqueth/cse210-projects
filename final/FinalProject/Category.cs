
public class Category {
    public string _categoryName { get; private set; }
    public List<Task> _tasks { get; private set; }

    public Category(string categoryName) {
        _categoryName = categoryName;
        _tasks = new List<Task>();
    }

    public void AddTask(Task task) {
        _tasks.Add(task);
    }

    public void RemoveTask(Task task) {
        _tasks.Remove(task);
    }

    public List<Task> GetTasks() {
        return _tasks;
    }
}
