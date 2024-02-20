
public class Category {
    private string _categoryName;
    private List<Task> _tasks;

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
