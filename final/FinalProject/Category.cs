
public class Category {
    public string CategoryName { get; private set; }
    public List<Task> Tasks { get; private set; }

    public Category(string categoryName) {
        CategoryName = categoryName;
        Tasks = new List<Task>();
    }

    public void AddTask(Task task) {
        Tasks.Add(task);
    }

    public void RemoveTask(Task task) {
        Tasks.Remove(task);
    }

    public List<Task> GetTasks() {
        return Tasks;
    }
}
