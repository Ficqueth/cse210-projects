public class Notification {
    public string Message { get; private set; }
    public Task Task { get; private set; }

    public Notification(string message, Task task) {
        Message = message;
        Task = task;
    }

    public void SendNotification() {
        // Implementation for sending notification
    }
}
