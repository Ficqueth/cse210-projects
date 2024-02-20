using System;

public class UI {
    private TaskList _taskList;

    public UI(TaskList taskList) {
        this._taskList = taskList;
    }

    public void DisplayMainMenu() {
        Console.WriteLine("TaskMaster Main Menu");
        Console.WriteLine("1. Add Task");
        Console.WriteLine("2. Remove Task");
        Console.WriteLine("3. Mark Task as Completed");
        Console.WriteLine("4. View Incomplete Tasks");
        Console.WriteLine("5. View Completed Tasks");
        Console.WriteLine("6. Sort Tasks");
        Console.WriteLine("7. Logout");
        Console.WriteLine("Enter your choice:");
    }

    public void Run() {
        bool loggedIn = true;
        while (loggedIn) {
            DisplayMainMenu();
            int choice = int.Parse(Console.ReadLine());
            switch (choice) {
                case 1:
                    // Prompt user to add task and add it to the task list
                    Console.WriteLine("Enter task description:");
                    string description = Console.ReadLine();
                    Console.WriteLine("Enter task deadline (YYYY-MM-DD):");
                    DateTime deadline = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter task priority (1 for high, 2 for medium, 3 for low):");
                    int priority = int.Parse(Console.ReadLine());
                    Task task = new Task(description, deadline, priority);
                    _taskList.AddTask(task);
                    break;
                case 2:
                    // Prompt user to remove task from the task list
                    Console.WriteLine("Enter task description to remove:");
                    string taskDescription = Console.ReadLine();
                    Task taskToRemove = _taskList.GetIncompleteTasks().Find(t => t.GetDescription() == taskDescription);
                    if (taskToRemove != null) {
                        _taskList.RemoveTask(taskToRemove);
                        Console.WriteLine("Task removed successfully.");
                    } else {
                        Console.WriteLine("Task not found.");
                    }
                    break;
                case 3:
                    // Prompt user to mark task as completed
                    Console.WriteLine("Enter task description to mark as completed:");
                    string taskDescriptionToComplete = Console.ReadLine();
                    Task taskToComplete = _taskList.GetIncompleteTasks().Find(t => t.GetDescription() == taskDescriptionToComplete);
                    if (taskToComplete != null) {
                        taskToComplete.MarkAsCompleted();
                        Console.WriteLine("Task marked as completed successfully.");
                    } else {
                        Console.WriteLine("Task not found.");
                    }
                    break;
                case 4:
                    // Display incomplete tasks
                    Console.WriteLine("Incomplete Tasks:");
                    foreach (var incompleteTask in _taskList.GetIncompleteTasks()) {
                        Console.WriteLine($"- {incompleteTask.GetDescription()}");
                    }
                    break;
                case 5:
                    // Display completed tasks
                    Console.WriteLine("Completed Tasks:");
                    foreach (var completedTask in _taskList.GetCompletedTasks()) {
                        Console.WriteLine($"- {completedTask.GetDescription()}");
                    }
                    break;
                case 6:
                    // Sort tasks
                    Console.WriteLine("Sort tasks by (1 for deadline, 2 for priority):");
                    int sortChoice = int.Parse(Console.ReadLine());
                    if (sortChoice == 1) {
                        _taskList.SortTasksByDeadline();
                    } else if (sortChoice == 2) {
                        _taskList.SortTasksByPriority();
                    }
                    Console.WriteLine("Tasks sorted successfully.");
                    break;
                case 7:
                    // Logout
                    loggedIn = false;
                    Console.WriteLine("Logged out successfully.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
