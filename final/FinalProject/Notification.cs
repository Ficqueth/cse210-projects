public class Notification {
    private string _message;
    private Task _task;

    public Notification(string message, Task task) {
        _message = message;
        _task = task;
    }

    public void SendNotification() {
        Console.WriteLine($"Notification: {_message}");
        Console.WriteLine($"Task Details - Description: {_task.GetDescription()}, Deadline: {_task.GetDeadline()}, Priority: {_task.GetPriority()}");
        // Trying to implement an email notification( not done)
    }
}
