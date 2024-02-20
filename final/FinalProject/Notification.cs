public class Notification {
    public string _message { get; private set; }
    public Task _task { get; private set; }

    public Notification(string message, Task task) {
        _message = message;
        _task = task;
    }

    public void SendNotification() {
        // Implementation for sending notification
    }
}
